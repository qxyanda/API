using System.Linq;
using Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
			return new ObjectResult(_db.PokerUsers.OrderByDescending(m => m.Id).Take(10).ToList());
        }

        // GET api/sync/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
			var model = _db.PokerUsers.FirstOrDefault(m => m.Id == id);
			if (model != null)
			{
				return new ObjectResult(model);
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
			var model = _db.PokerUsers.Include(m => m.wallets).FirstOrDefault(m => m.Id == id);
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
			var models = _db.Wallets.OrderByDescending(m => m.Id == id);
			if (models != null)
			{
                foreach(var modelOnDeleting in models)
				_db.Wallets.Remove(modelOnDeleting);
                var model = _db.PokerUsers.FirstOrDefault(m => m.Id == id);
                if (model != null)
                {
                    _db.PokerUsers.Remove(model);
                }
				_db.SaveChanges();
				return Ok();
			}

			return NotFound();
        }
    }
}
