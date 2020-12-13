using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Users.Models;
using UserContexts.Models;
using System;

namespace UserController.Controllers
{
    [Route("api/[controller]")]
    public class GetUserInfoController : ControllerBase
    {
        [HttpGet]
        public List<User> Get()
        {
            using (UserContext _userContext = new UserContext())
            {
                Console.WriteLine(_userContext.User);
                return _userContext.Set<User>().ToList();
            }
        }
    }
}