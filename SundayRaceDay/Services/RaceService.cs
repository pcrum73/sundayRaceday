using MongoDB.Driver;

using SundayRaceDay.Models.ViewModels;
using SundayRaceDay.Services.Interfaces;

namespace SundayRaceDay.Services
{
    public class RaceService : IRaceService
    {
        private readonly MongoClient _mongoClient;

        public RaceService(MongoClientSettings mongoClientSettings)
        {
            _mongoClient = new MongoClient(mongoClientSettings);
        }
        public async Task<Race> Create(Track track, List<Restriction> restrictions)
        {
            if (track == null)
            {
                return new Race(1);
            }
            else
            {
                return new Race(1, track, restrictions);
            }
        }

        public async Task<Race> Get(long raceId)
        {
            return new Race(raceId);
        }

        public async Task<List<Race>> GetAll(long seriesId)
        {
            return new List<Race> { new Race(1), new Race(2) };
        }
    }
}
