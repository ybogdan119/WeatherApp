namespace WeatherApp.Models
{
    public class Day
    {
        public float Maxtemp_c { get; set; }
        public float Maxtemp_f { get; set; }
        public float Mintemp_c { get; set; }
        public float Mintemp_f { get; set; }
        public float Avgtemp_c { get; set; }
        public float Avgtemp_f { get; set; }
        public float Maxwind_mph { get; set; }
        public float Maxwind_kph { get; set; }
        public float Totalprecip_mm { get; set; }
        public float Totalprecip_in { get; set; }
        public float Totalsnow_cm { get; set; }
        public float Avgvis_km { get; set; }
        public float Avgvis_miles { get; set; }
        public float Avghumidity { get; set; }
        public int Daily_will_it_rain { get; set; }
        public int Daily_chance_of_rain { get; set; }
        public int Daily_will_it_snow { get; set; }
        public int Daily_chance_of_snow { get; set; }
        public Condition Condition { get; set; } = new();
        public float Uv { get; set; }
    }
}
