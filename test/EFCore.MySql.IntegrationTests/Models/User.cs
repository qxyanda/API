using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Models
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

    public class User
    {
        public int Id { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
		public string NickName { get; set; }
        public string Session { get; set; }
    }

}
