using Diary.Entities;

namespace Diary.Interfaces
{
    public interface IDaysRepository
    {
        Task<IEnumerable<Day>> GetDays();
        Task<Day> GetDayById(int id);
        public Task Create(Day day);
    }
}
