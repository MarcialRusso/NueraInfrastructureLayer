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
        
        public DbSet<HouseholdItem> HouseholdItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>();
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=Nuera; Database=EFProviders.InMemory; Integrated Security=True;ConnectRetryCount=0");
                    //"Server=(localdb)\mssqllocaldb;Trusted_Connection=True;ConnectRetryCount=0");
            }
        }
    }
}