using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models
{
    public class Wallet
    {
        public int PersonId { get; set; }
        [Key]
        public int Id { get; set; }
        public int Type { get; set; }
        public string Address { get; set; }
        public int Balance { get; set; }
        public int Decimals { get; set; }
        public List<WalletHistory> walletHistory { get; set; }
    }
}
