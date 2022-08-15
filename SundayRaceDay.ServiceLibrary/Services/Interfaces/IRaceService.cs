using SundayRaceDay.ServiceLibrary.DTOs;

namespace SundayRaceDay.ServiceLibrary.Services.Interfaces
{
    public interface IRaceService
    {
        Task<Race> Get(long raceId);
        Task<List<Race>> GetAll(long seriesId);
        Task<Race> Create(Track track = null, List<Restriction> restrictions = null);
    }
}
