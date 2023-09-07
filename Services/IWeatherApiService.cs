using System.Reflection;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public interface IWeatherApiService
    {
        public Task<Rootobject?> GetForecastAsync(string location, int days = 3);
    }
}
