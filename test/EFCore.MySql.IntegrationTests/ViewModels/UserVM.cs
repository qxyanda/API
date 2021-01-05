using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models;

namespace ViewModels
{
    public class UserVM
    {
        public string UserName { get; set; }
		public string NickName { get; set; }
        public string Session { get; set; }

        public UserVM()
        {
            UserName = "";
            NickName = "";
            Session = "";
        }

        public UserVM(string userName, string nickName, string session)
        {
            UserName = userName;
            NickName = nickName;
            Session = session;
        }
    }


}
