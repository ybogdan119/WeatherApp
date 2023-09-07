namespace WeatherApp.Models.ViewModels
{
    public class WeatherViewModel
    {
        public CurrentViewModel Current{ get; set; } = new CurrentViewModel();
        public ForecastDayViewModel[] Forecast { get; set; } = Array.Empty<ForecastDayViewModel>();
        public string Location { get; set; } = string.Empty;
    }
}
