namespace WeatherApp.Models.ViewModels
{
    public class ForecastDayViewModel
    {
        public string Date { get; set; } = string.Empty;
        public float MaxTemperature { get; set; }
        public float MinTemperature { get; set; }
        public HourViewModel[] Hours { get; set; } = Array.Empty<HourViewModel>();
    }
}
