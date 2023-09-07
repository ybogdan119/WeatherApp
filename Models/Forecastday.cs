namespace WeatherApp.Models
{
    public class Forecastday
    {
        public string Date { get; set; } = string.Empty;
        public int Date_epoch { get; set; }
        public Day Day { get; set; } = new();
        public Astro Astro { get; set; } = new();
        public Hour[] Hour { get; set; } = Array.Empty<Hour>();
    }

}
