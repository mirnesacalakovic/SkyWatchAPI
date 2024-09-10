namespace SkyWatch_API.Models.WeatherModels
{
    public class LocationWeather
    {
        public double queryCost { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string resolvedAddress { get; set; }
        public string address { get; set; }
        public string timezone { get; set; }
        public double tzoffset { get; set; }
        public string description { get; set; }
        public List<Day> days { get; set; }
        public List<Alert> alerts { get; set; }
        public Stations stations { get; set; }
        public CurrentConditions currentConditions { get; set; }
    }
}
