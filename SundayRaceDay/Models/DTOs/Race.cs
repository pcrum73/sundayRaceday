namespace SundayRaceDay.Models.DTOs
{
    public class Race
    {
        public List<Stat> Stats { get; set; }
        public List<Driver> Drivers { get; set; }
        public Track Track { get; set; }
        public List<Restriction> Restrictions { get; set; }

    }
}
