using Diary.Entities;
namespace Diary.Interactions
{
    public class DataInitializator
    {
        private readonly DataContext _dataContext;

        public DataInitializator(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void InitTables()
        {
            if (_dataContext.Days.Any())
            {
                return;
            }

            List<Day> days = new()
        {
            new Day()
            {
                Name = "Monday"
            },
            new Day()
            {
                Name = "Tuesday"
            },
            new Day()
            {
                Name = "Wednsday"
            },
            new Day()
            {
                Name = "Thursday"
            },
            new Day()
            {
                Name = "Friday"
            },
            new Day()
            {
                Name = "Saturday"
            },
            new Day()
            {
                Name = "Sunday"
            }
            };
            DateTime date = new DateTime(2022, 9, 12, 9, 30,0);
            List<Affairs> Affairs = new()
            {
                new Affairs(){
                Name = "Hockey",
                Status = "Important",
                StartTime = (date),
                EndTime=(new DateTime(2022, 9, 12, 11, 30, 0))
                }
            };
            Schedule schedule = new Schedule()
            {
                DayId = 1,
                affairs = Affairs
            };
            _dataContext.Schedule.Add(schedule);
            foreach(var item in days)
            {
                _dataContext.Days.Add(item);
            }

            _dataContext.SaveChanges();
        }
    }
}
