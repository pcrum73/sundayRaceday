using SundayRaceDay.Models.ViewModels;

namespace SundayRaceDay.Services.Interfaces
{
    public interface IRaceService
    {
        Task<Race> Get(long raceId);
        Task<List<Race>> GetAll(long seriesId);
        Task<Race> Create(Track track = null, List<Restriction> restrictions = null);
    }
}
