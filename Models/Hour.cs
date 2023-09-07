namespace WeatherApp.Models
{
    public class Hour
    {
        public int Time_epoch { get; set; }
        public string Time { get; set; } = string.Empty;
        public float Temp_c { get; set; }
        public float Temp_f { get; set; }
        public int Is_day { get; set; }
        public Condition Condition { get; set; } = new();
        public float Wind_mph { get; set; }
        public float Wind_kph { get; set; }
        public int Wind_degree { get; set; }
        public string Wind_dir { get; set; } = string.Empty;
        public float Pressure_mb { get; set; }
        public float Pressure_in { get; set; }
        public float Precip_mm { get; set; }
        public float Precip_in { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        public float Feelslike_c { get; set; }
        public float Feelslike_f { get; set; }
        public float Windchill_c { get; set; }
        public float Windchill_f { get; set; }
        public float Heatindex_c { get; set; }
        public float Heatindex_f { get; set; }
        public float Dewpoint_c { get; set; }
        public float Dewpoint_f { get; set; }
        public int Will_it_rain { get; set; }
        public int Chance_of_rain { get; set; }
        public int Will_it_snow { get; set; }
        public int Chance_of_snow { get; set; }
        public float Vis_km { get; set; }
        public float Vis_miles { get; set; }
        public float Gust_mph { get; set; }
        public float Gust_kph { get; set; }
        public float Uv { get; set; }
    }
}
