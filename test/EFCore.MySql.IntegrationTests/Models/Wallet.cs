using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models
{
    public class Wallet
    {
        public int Id { get; set; }
        public string address { get; set; }
        public int balance { get; set; }
        public int decimals { get; set; }
        public int onDeposite { get; set; }
        public int onWithdraw { get; set; }
        public int isDepdited { get; set; }
        public int isWthdrawed { get; set; }

        public User User { get; set; }
    }
}
