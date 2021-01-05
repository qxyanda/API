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
			return new ObjectResult(_db.Admins.Include(m => m.Games).OrderByDescending(m => m.Id).Take(10).ToList());
        }

        // GET api/sync/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
			var model = _db.Admins.Include(m => m.Games).FirstOrDefault(m => m.Id == id);
			if (model != null)
			{
				return new ObjectResult(model);
			}
			return NotFound();
        }
    }
}
