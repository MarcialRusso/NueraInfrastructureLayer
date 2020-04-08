using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Context;
using Infrastructure.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class HouseholdItemRepository : IHouseholdItemRepository
    {
        private NueraContext _context;

        public HouseholdItemRepository(NueraContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HouseholdItem>> GetAllAsync()
        {
            return await _context.HouseholdItems.ToListAsync();
        }

        public Task<HouseholdItem> GetByIdAsync(Guid householdItemId)
        {
            return _context.HouseholdItems.FirstOrDefaultAsync(h => h.Id == householdItemId);
        }

        public void Insert(HouseholdItem householdItem)
        {
            _context.HouseholdItems.Add(householdItem);
        }

        public void Update(HouseholdItem householdItem)
        {
            _context.Entry(householdItem).State = EntityState.Modified;
        }

        public async Task DeleteAsync(Guid householdItemId)
        {
            var item = await GetByIdAsync(householdItemId);
            _context.HouseholdItems.Remove(item);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}