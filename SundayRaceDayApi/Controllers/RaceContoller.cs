using Microsoft.AspNetCore.Mvc;

using SundayRaceDay.ServiceLibrary.Services.Interfaces;

using SundayRaceDayApi.Models.ApiModels;

namespace SundayRaceDayApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RaceContoller : ControllerBase
    {

        private readonly ILogger<RaceContoller> _logger;
        private readonly IRaceService raceService;

        public RaceContoller(ILogger<RaceContoller> logger, IRaceService raceService)
        {
            _logger = logger;
            this.raceService = raceService;
        }

        [HttpPost(Name = "Create")]
        public async Task<Race> Create(Track track, List<Restriction> restrictions)
        {
            var race = new Race();
            return race.ToApiModel(await raceService.Create());
        }
    }
}