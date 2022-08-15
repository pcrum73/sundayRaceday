using DTOs = SundayRaceDay.ServiceLibrary.DTOs;

namespace SundayRaceDayApi.Models.ApiModels
{
    public class Race
    {
        //public List<Stat> Stats { get; set; }
        //public List<Driver> Drivers { get; set; }
        public string Status { get; set; }
        public Track Track { get; set; }
        public List<Restriction> Restrictions { get; set; }
        public long RaceNumber { get; set; }

        public Race ToApiModel(DTOs.Race race)
        {
            return new Race
            {
                Track = new Track
                {
                     TrackType = race.Track.TrackType
                },
                RaceNumber = race.RaceNumber,
                Status = Enum.GetName(typeof(DTOs.RaceStatus), race.Status).ToString(),
                //Stats = race.Stats
            };
        }

    }
}
