using Diary.Entities;
using Diary.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Diary.Interactions.Services
{
    public class AffairsRepository : IAffairsRepository
    {
        private readonly DataContext _context;
        public async Task Create(Affairs affair)
        {
            if (affair is null)
                throw new NullReferenceException(nameof(affair));
            await _context.Affairs.AddAsync(affair);
        }

        public async Task<Affairs> GetAffairsById(int id)
        {
            var affairs = await _context.Affairs.FindAsync(id);

            if (affairs is null)
                throw new NullReferenceException(nameof(affairs));

            return affairs;
        }

        public async Task<IEnumerable<Affairs>> GetAffairs()
        {
            var affairs = await _context.Affairs.ToListAsync();
            if (affairs is null)
                throw new NullReferenceException(nameof(affairs));
            return affairs;
        }
    }
}
