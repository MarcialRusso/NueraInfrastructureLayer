using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Entities;

namespace Infrastructure.Interfaces
{
    public interface IHouseholdItemRepository
    {
        Task<IEnumerable<HouseholdItem>> GetAllAsync();
        Task<HouseholdItem> GetByIdAsync(Guid householdItemId);
        void Insert(HouseholdItem householdItem);
        void Update(HouseholdItem householdItem);
        Task DeleteAsync(Guid householdItemId);
        Task SaveAsync();
    }
}