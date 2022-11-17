using Diary.Entities;

namespace Diary.Interfaces
{
    public interface IScheduleRepository
    {
        Task<IEnumerable<Schedule>> GetSchedules();
        Task<Schedule> GetScheduleById(int id);
        Task<Schedule> GetScheduleByDay(int DayId);
        public Task Create(Schedule schedule);
    }
}
