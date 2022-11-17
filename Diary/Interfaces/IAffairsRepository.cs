using Diary.Entities;

namespace Diary.Interfaces
{
    public interface IAffairsRepository
    {
        Task<IEnumerable<Affairs>> GetAffairs();
        Task<Affairs> GetAffairsById(int id);
        public Task Create(Affairs affairs);
    }
}
