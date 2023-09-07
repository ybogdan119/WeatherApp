namespace WeatherApp.Models
{
    public class Forecast
    {
        public Forecastday[] Forecastday { get; set; } = Array.Empty<Forecastday>();
    }
}
