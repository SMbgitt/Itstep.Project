using Diary.Entities;
using Diary.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Diary.Interactions.Services
{
    public class DayRepository : IDaysRepository
    {
        private readonly DataContext _context;
        
        public async Task Create(Day day)
        {
            if (day is null)
                throw new NullReferenceException(nameof(day));
            await _context.Days.AddAsync(day);
        }

        public async Task<Day> GetDayById(int id)
        {
            var day = await _context.Days.FindAsync(id);

            if (day is null)
                throw new NullReferenceException(nameof(day));

            return day;
        }

        public async Task<IEnumerable<Day>> GetDays()
        {
            var days = await _context.Days.ToListAsync();

            if (days is null)
                throw new NullReferenceException(nameof(days));

            return days;
        }
    }
}
/*using Itstep.Delivery.GlobalDictionary.Api.Entities;
using Itstep.Delivery.GlobalDictionary.Api.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace Itstep.Delivery.GlobalDictionary.Api.Persistance.Services;

public class CityRepository : ICityRepository
{
    private readonly ILogger<CityRepository> _logger;
    private readonly IDataContext _context;

    public CityRepository(ILogger<CityRepository> logger, IDataContext context)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task Create(City city)
    {
        if (city is null)
            throw new NullReferenceException(nameof(city));
        await _context.Cities.Add(city);
        return Ok();
    }


    public async Task<IEnumerable<City>> GetCities()
    {
        var cities = await _context.Cities.ToListAsync();

        if (cities is null)
            throw new NullReferenceException(nameof(cities));

        return cities;
    }

    public async Task<City> GetCityById(int id)
    {
        var city = await _context.Cities.FindAsync(id);

        if (city is null)
            throw new NullReferenceException(nameof(city));

        return city;
    }
}
*/
