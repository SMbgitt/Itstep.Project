using Diary.Entities;
using Diary.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Diary.Interactions.Services
{
    public class ScheduleRepository:IScheduleRepository
    {
        private readonly DataContext _context;
        public async Task Create(Schedule schedule)
        {
            if (schedule is null)
                throw new NullReferenceException(nameof(schedule));
            await _context.Schedule.AddAsync(schedule);
        }

        public async Task<Schedule> GetScheduleById(int id)
        {
            var schedule = await _context.Schedule.FindAsync(id);

            if (schedule is null)
                throw new NullReferenceException(nameof(schedule));

            return schedule;
        }

        public async Task<IEnumerable<Schedule>> GetSchedules()
        {
            var Schedule = await _context.Schedule.ToListAsync();
            if (Schedule is null)
                throw new NullReferenceException(nameof(Schedule));
            return Schedule;
        }

        public  Task<Schedule> GetScheduleByDay(int Dayid)
        {
            var schedule =  _context.Schedule.Where(x => x.DayId == Dayid).FirstOrDefault(;

            if (schedule is null)
                throw new NullReferenceException(nameof(schedule));

            return schedule;
        }
    }
}
