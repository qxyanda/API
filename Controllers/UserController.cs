﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using Users.Entitis;
using UsersDbContext.Entities;


namespace UserController.Controllers
{
    [Route("api/[controller]")]
    public class GetUserInfoController : ControllerBase
    {
        // [HttpGet]
        // public List<User> Get()
        // {
        //     using (UserDbContext _userContext = new UserDbContext())
        //     {
        //         Console.WriteLine(_userContext.User);
        //         return _userContext.Set<User>().ToList();
        //     }
        // }
    }
}