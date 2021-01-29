using System.Linq;
using Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models;
using Microsoft.AspNetCore.Mvc;
using ViewModels;
using System.Collections.Generic;
using System;
using StackExchange.Redis;
using RedisDemo;
using Newtonsoft.Json;


namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
	    private readonly AppDb _db;
        private readonly IDatabase _redis;

        private readonly int cacheTime = 600;

	    public PersonController(AppDb db,RedisHelper client)
	    {
		    _db = db;
            _redis = client.GetDatabase();
	    }

	    // GET api/sync
        [HttpGet]
        public IActionResult Get()
        {
            Test();
            // 从Redis里面取数据
            string value = _redis.StringGet("/api/Person/");

            if(!string.IsNullOrEmpty(value))
            {
                return new ObjectResult(JsonConvert.DeserializeObject(value));
            }

            // var models = _db.People.OrderBy(m => m.Id).Take(10).ToList();

            //等效

            var sqls =
            (
                from m in _db.People
                orderby m.Id
                select new {m.Id,m.UserName}
            ).Take(10);

            var models = sqls.ToList();

            if(models != null)
            {
                // 往Redis里面存入数据
                _redis.StringSet("/api/Person/", $"{JsonConvert.SerializeObject(models)}",TimeSpan.FromSeconds(cacheTime));
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
            // 从Redis里面取数据
            string value = _redis.StringGet("/api/Person/"+id);

            if(!string.IsNullOrEmpty(value))
            {
                return new ObjectResult(JsonConvert.DeserializeObject(value));
            }
            //
            //SELECT
            //
            // var model = _db.People.Where(m => m.Id == id).Select(m => new {m.UserName, m.PassWord});

            // Console.WriteLine(_db.People.Where(m => m.Id == id).Select(m => new {m.UserName,m.PassWord}).ToString());

			// var model = _db.People.FirstOrDefault(m => m.Id == id);

            var sqls =
            (
                from m in _db.People
                where m.Id == id
                select new {m.Id,m.UserName}
            );

            var model = sqls;

			if (model != null && !$"{JsonConvert.SerializeObject(model)}".Equals("[]"))
			{
                // 往Redis里面存入数据
                _redis.StringSet("/api/Person/"+id, $"{JsonConvert.SerializeObject(model)}",TimeSpan.FromSeconds(cacheTime));
				return new ObjectResult(model);
			}
			return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person body)
        {
	        _db.People.Add(body);
	        _db.SaveChanges();
            _redis.KeyDelete("/api/Person/");
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
                _redis.KeyDelete("/api/Person/");
                _redis.KeyDelete("/api/Person/"+id);
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
                _redis.KeyDelete("/api/Person/");
                _redis.KeyDelete("/api/Person/"+id);
                return Ok();
            }

			return NotFound();
        }

        public void Test()
        {
            // string path = @"d:\test\123.sqlite";
            // SqliteConnection cn = new SQLiteConnection("data source=" + path);
            // cn.Open();
            // cn.Close();
        }
    }
}
