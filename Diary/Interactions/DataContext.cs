
using Diary.Entities;
using Microsoft.EntityFrameworkCore;

namespace Diary.Interactions;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Day> Days { get; set; }
    public DbSet<Affairs> Affairs { get; set; }
    public DbSet<Schedule> Schedule { get; set; }
}