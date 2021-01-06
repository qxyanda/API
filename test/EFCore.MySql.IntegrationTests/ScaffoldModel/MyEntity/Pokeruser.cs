using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class Pokeruser
    {
        public Pokeruser()
        {
            Wallets = new HashSet<Wallet>();
        }

        public int Id { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string Session { get; set; }

        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
