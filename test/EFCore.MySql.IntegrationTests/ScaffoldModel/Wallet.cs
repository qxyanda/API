using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class Wallet
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Balance { get; set; }
        public int Decimals { get; set; }
        public int OnDeposite { get; set; }
        public int OnWithdraw { get; set; }
        public int IsDepdited { get; set; }
        public int IsWthdrawed { get; set; }
        public int? UserId { get; set; }

        public virtual Pokeruser User { get; set; }
    }
}
