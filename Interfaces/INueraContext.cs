using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Interfaces
{
    // TODO - DB sets should be filtered
    public interface INueraContext
    {
        DbSet<Category> Categories { get; }
        DbSet<HouseholdItem> HouseholdItems { get; }
        DbSet<User> Users { get; }
    }
}