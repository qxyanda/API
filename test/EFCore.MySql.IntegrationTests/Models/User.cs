using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ViewModels;


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
		}
	}

    public class User : UserVM
    {
        public int Id { get; set; }
        public string PassWord { get; set; }
    }

}
