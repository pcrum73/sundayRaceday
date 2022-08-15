using MongoDB.Driver;

using SundayRaceDay.ServiceLibrary.DTOs;
using SundayRaceDay.ServiceLibrary.Services.Interfaces;

namespace SundayRaceDay.ServiceLibrary.Services
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
            return new Race();
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
