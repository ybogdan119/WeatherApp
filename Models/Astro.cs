namespace WeatherApp.Models
{
    public class Astro
    {
        public string Sunrise { get; set; } = string.Empty;
        public string Sunset { get; set; } = string.Empty;
        public string Moonrise { get; set; } = string.Empty;
        public string Moonset { get; set; } = string.Empty;
        public string Moon_phase { get; set; } = string.Empty;
        public string Moon_illumination { get; set; } = string.Empty;
        public int Is_moon_up { get; set; }
        public int Is_sun_up { get; set; }
    }
}
