using System.Linq;
using Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models;
using Microsoft.AspNetCore.Mvc;
using ViewModels;
using System.Collections.Generic;
using System;

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
	    private readonly AppDb _db;

	    public PersonController(AppDb db)
	    {
		    _db = db;
	    }

	    // GET api/sync
        [HttpGet]
        public IActionResult Get()
        {
            var models = _db.People.OrderBy(m => m.Id).Take(10).ToList();
            if(models != null)
            {
                return new ObjectResult(models);
                // List<Person> viewModels = new List<Person>();
                // foreach( var model in models)
                // {
                //     viewModels.Add(new Person(model.UserName,model.NickName,model.Session));
                // }
                // return new ObjectResult(viewModels);
            }
            return NotFound();
        }

        // GET api/sync/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //
            //SELECT
            //
            var model = _db.People.Where(m => m.Id == id).Select(m => new {m.UserName,m.PassWord});
            // Console.WriteLine(_db.People.Where(m => m.Id == id).Select(m => new {m.UserName,m.PassWord}).ToString());

			// var model = _db.People.FirstOrDefault(m => m.Id == id);
			if (model != null)
			{
				return new ObjectResult(model);
			}
			return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person body)
        {
	        _db.People.Add(body);
	        _db.SaveChanges();
			return new ObjectResult(body);
        }

        // // PUT api/sync/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Person body)
        {
			var model = _db.People.FirstOrDefault(m => m.Id == id);
			if (model != null)
			{
				model.PassWord = body.PassWord;
				_db.SaveChanges();
				return new ObjectResult(model);
			}
			return NotFound();
        }

        // // DELETE api/sync/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var model = _db.People.FirstOrDefault(m => m.Id == id);
            if (model != null)
            {
                var wallets = _db.Wallets.OrderByDescending(m => m.PersonId == id);
                foreach(var wallet in wallets)
                {
                    _db.Wallets.Remove(wallet);
                }
                _db.People.Remove(model);
                _db.SaveChanges();
                return Ok();
            }

			return NotFound();
        }
    }
}
