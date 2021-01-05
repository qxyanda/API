using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models
{
    public static class UsersMeta
	{
		public static void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>(entity =>
			{
				entity.HasKey(m => m.Id)
                ;
            });
            modelBuilder.Entity<Wallet>(entity =>
			{
				entity.HasKey(m => m.Id)
                ;
            });
		}
	}

    public class User
    {
        public int Id { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
		public string NickName { get; set; }

        public List<Wallet> wallets { get; set; }
    }

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
    }

}
