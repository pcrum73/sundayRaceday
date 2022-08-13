using SundayRaceDay.Models.ViewModels;
using SundayRaceDay.Services.Interfaces;

namespace SundayRaceDay.Services
{
    public class RaceService : IRaceService
    {
        public async Task<Race> Create(Track track, List<Restriction> restrictions)
        {
            if (track == null)
            {
                return new Race();
            }
            else
            {
                return new Race(track, restrictions);
            }
        }

        public async Task<Race> Get(long raceId)
        {
            return new Race();
        }

        public async Task<List<Race>> GetAll(long seriesId)
        {
            return new List<Race> { new Race(), new Race() };
        }
    }
}
