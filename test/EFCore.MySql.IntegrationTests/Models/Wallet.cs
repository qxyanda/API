using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Models
{
    public static class WalletsMeta
	{
		public static void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Wallet>(entity =>
			{
				entity.HasKey(m => m.Id)
                ;
            });
		}
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

        public User User { get; set; }
    }
}
