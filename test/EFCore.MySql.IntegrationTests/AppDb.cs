using Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests
{
    public class AppDb : IdentityDbContext<AppIdentityUser>
    {
        //Log
        public DbSet<Log> Logs { get; set; }
        //Person
        public DbSet<Person> People { get; set; }
        //Wallet
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WalletHistory> WalletHistories { get; set; }

        public AppDb(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add our models fluent APIs
            PeopleMeta.OnModelCreating(modelBuilder);

            // modelBuilder.Entity<AppIdentityUser>(entity =>
            // {
            //     entity.Property(m => m.Email).HasMaxLength(127);
            //     entity.Property(m => m.NormalizedEmail).HasMaxLength(127);
            //     entity.Property(m => m.NormalizedUserName).HasMaxLength(127);
            //     entity.Property(m => m.UserName).HasMaxLength(127);
            // });
            // modelBuilder.Entity<IdentityRole>(entity =>
            // {
            //     entity.Property(m => m.Name).HasMaxLength(127);
            //     entity.Property(m => m.NormalizedName).HasMaxLength(127);
            // });
            // modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            // {
            //     entity.Property(m => m.LoginProvider).HasMaxLength(127);
            //     entity.Property(m => m.ProviderKey).HasMaxLength(127);
            // });
            // modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            // {
            //     entity.Property(m => m.UserId).HasMaxLength(127);
            //     entity.Property(m => m.RoleId).HasMaxLength(127);
            // });
            // modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            // {
            //     entity.Property(m => m.UserId).HasMaxLength(127);
            //     entity.Property(m => m.LoginProvider).HasMaxLength(127);
            //     entity.Property(m => m.Name).HasMaxLength(127);

            // });

        }
    }
}
