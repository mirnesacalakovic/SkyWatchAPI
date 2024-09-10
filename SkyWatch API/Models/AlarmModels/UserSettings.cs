namespace SkyWatch_API.Models.AlarmModels
{
    public class UserSettings
    {
        public string Selected { get; set; }
        public WeatherCondition Thunderstorm { get; set; }
        public WeatherCondition Rain { get; set; }
        public WeatherCondition Heat { get; set; }
        public WeatherCondition Snow { get; set; }
        public WeatherCondition Wind { get; set; }
    }
}
