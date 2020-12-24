using Microsoft.EntityFrameworkCore;
using Users.Entitis;

namespace UsersDbContext.Entities
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> User { get; set; }

        
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            
        }

    }
}