using System.Collections.Generic;
using Infrastructure.Entities;

namespace Infrastructure.Interfaces
{
    public interface IHouseholdItemRepository
    {
        IEnumerable<HouseholdItem> GetAll();
        HouseholdItem GetById(int householdItemId);
        void Insert(HouseholdItem householdItem);
        void Update(HouseholdItem householdItem);
        void Delete(int householdItemId);
        void Save();
    }
}