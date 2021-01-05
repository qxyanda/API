using System;
using System.Linq;
using Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModels;
using Models;
using System.Collections.Generic;

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
	    private readonly AppDb _db;

	    public UserController(AppDb db)
	    {
		    _db = db;
	    }

	    // GET api/sync
        [HttpGet]
        public IActionResult Get()
        {
            var models = _db.PokerUsers.OrderBy(m => m.Id).Take(10).ToList();
            List<UserVM> viewModels = new List<UserVM>();
            foreach( var model in models)
            {
                viewModels.Add(new UserVM(model.UserName,model.NickName,model.Session));
            }
			return new ObjectResult(viewModels);
        }

        // GET api/sync/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
			var model = _db.PokerUsers.FirstOrDefault(m => m.Id == id);
			if (model != null)
			{
				return new ObjectResult(new UserVM(model.UserName,model.NickName,model.Session));
			}
			return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] User body)
        {
	        _db.PokerUsers.Add(body);
	        _db.SaveChanges();
			return new ObjectResult(body);
        }

        // PUT api/sync/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User body)
        {
			var model = _db.PokerUsers.FirstOrDefault(m => m.Id == id);
			if (model != null)
			{
				model.PassWord = body.PassWord;
				_db.SaveChanges();
				return new ObjectResult(model);
			}
			return NotFound();
        }

        // DELETE api/sync/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            var model = _db.PokerUsers.FirstOrDefault(m => m.Id == id);
            if (model != null)
            {
                var wallets = _db.Wallets.OrderByDescending(m => m.User.Id == id);
                foreach(var wallet in wallets)
                {
                    _db.Wallets.Remove(wallet);
                }
                _db.PokerUsers.Remove(model);
                _db.SaveChanges();
                return Ok();
            }

			return NotFound();
        }
    }
}
