using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Users.Models;
using UserContexts.Models;
using System;

namespace Test
{
    public class GetUserInfoTest
    {
        public List<User> Main()
        {
            using (UserContext _userContext = new UserContext())
            {
                return _userContext.Set<User>().ToList();
            }
        }
    }
}