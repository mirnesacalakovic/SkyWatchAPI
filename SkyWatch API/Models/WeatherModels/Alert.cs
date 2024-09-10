namespace SkyWatch_API.Models.WeatherModels
{
    public class Alert
    {
        public string @event { get; set; }
        public string headline { get; set; }
        public DateTime ends { get; set; }
        public double endsEpoch { get; set; }
        public DateTime onset { get; set; }
        public double onsetEpoch { get; set; }
        public string id { get; set; }
        public string language { get; set; }
        public string link { get; set; }
        public string description { get; set; }
    }


}
