using Infrastructure.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class NueraContext : DbContext, INueraContext
    {
        public NueraContext(DbContextOptions<NueraContext> options) : base(options)
        {
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<HouseholdItem> HouseholdItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>();
            base.OnModelCreating(builder);
        }
    }
}