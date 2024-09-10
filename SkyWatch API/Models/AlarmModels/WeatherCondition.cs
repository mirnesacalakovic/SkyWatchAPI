namespace SkyWatch_API.Models.AlarmModels
{
    public class WeatherCondition
    {
        public int Id { get; set; }
        public int Precip { get; set; }
        public int Cloudcover { get; set; }
        public int Temp { get; set; }
        public int UvIndex { get; set; }
        public int Snow { get; set; }
        public int Windspeed { get; set; }
        public int Windgust { get; set; }
    }
}
