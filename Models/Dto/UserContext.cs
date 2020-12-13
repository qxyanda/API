using Microsoft.EntityFrameworkCore;
using Users.Models;

namespace UserContexts.Models
{
    public class UserContext : DbContext
    {
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(@"server=localhost;uid=root;password=19920821;
                    port=3306;database=ubet;sslmode=Preferred;");
            }
        }
    }
}