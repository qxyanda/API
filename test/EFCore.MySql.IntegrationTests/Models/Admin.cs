using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models
{
    public static class AdminsMeta
	{
		public static void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Admin>(entity =>
			{
				entity.HasKey(m => m.Id)
                ;
            });
            modelBuilder.Entity<Game>(entity =>
			{
				entity.HasKey(m => m.Id)
                ;
            });
		}
	}

    public class Admin
    {
        public int Id { get; set; }
		public string Name { get; set; }
        public List<Game> Games { get; set; }
    }
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
