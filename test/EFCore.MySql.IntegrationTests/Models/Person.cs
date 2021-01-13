using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models
{
    public static class PeopleMeta
	{
		public static void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Person>(entity =>
			{
				// index the Discriminator to prevent full table scan
				entity.HasKey(m => m.Id);
			});
		}
	}
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string NickName { get; set; }
        public string Session { get; set; }
        public List<Wallet> wallet { get; set; }
        public List<WalletHistory> walletHistory { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }

        public void SignOut()
        {}
        public void Diposite()
        {}
        public void Withdraw()
        {}
    }
}
