using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebItProject.Models.Entities;
using WebItProject.Models.Identity;

namespace WebItProject.Data
{
    public class MyContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public MyContext(DbContextOptions<MyContext> options)
    : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<SubscriptionType>()
                .Property(x => x.Price)
                .HasPrecision(8, 2);

            base.OnModelCreating(builder);
            builder.Entity<Subscription>()
                .Property(x => x.Amount)
                .HasPrecision(8, 2);

            base.OnModelCreating(builder);
            builder.Entity<Subscription>()
                .Property(x => x.PaidAmount)
                .HasPrecision(8, 2);

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<SubscriptionType> SubscriptionTypes { get; set; }
    }
}