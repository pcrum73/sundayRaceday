using SundayRaceDay.Models.DTOs;

namespace SundayRaceDay.Models.ViewModels
{
    public class Race
    {
        public List<Stat> Stats { get; set; }
        public List<Driver> Drivers { get; set; }
        public Track Track { get; set; }
        public List<Restriction> Restrictions { get; set; }
        public RaceStatus Status { get; set; }
        public long RaceNumber { get; set; }

        public Race(long raceNumber)
        {
            Stats = new List<Stat>();
            Drivers = new List<Driver>();
            Restrictions = new List<Restriction>();
            Status = RaceStatus.Pending;
            Track = new Track
            {
                 TrackType = TrackType.Street
            };
            RaceNumber = raceNumber;
        }
        public Race(long raceNumber, Track track = null, List<Restriction> restrictions = null)
            :this(raceNumber)
        {
            if (track != null)
            {
                this.Track = track;
            }
            if (restrictions != null)
            {
                this.Restrictions = restrictions;
            }
        }

        public Race SetTrack(Track track)
        {
            Track = track;
            return this;
        }
        public Race SetStatus(RaceStatus raceStatus)
        {
            Status = raceStatus;
            return this;
        }

    }
}
