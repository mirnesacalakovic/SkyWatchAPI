using SkyWatch_API.Models.AlarmModels;

namespace SkyWatch_API.Models
{
    public class Alarm
    {
        public int Id { get; set; }
        public string Type { get; set; } // Dodajemo tip alarma (npr. 'wind', 'rain', itd.)
        public WeatherCondition Conditions { get; set; }
        public string UserId { get; set; }
    }
}
