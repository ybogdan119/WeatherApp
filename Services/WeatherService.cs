using Newtonsoft.Json;
using System.Text;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService : IWeatherApiService
    {
        IConfiguration _config;
        public WeatherService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<Rootobject?> GetForecastAsync(string location, int days = 3)
        {
            StringBuilder url = new StringBuilder();
            url.Append(_config.GetValue<string>("WeatherApi:BaseUrl"));
            url.Append(_config.GetValue<string>("WeatherApi:Endpoints:Forecast"));
            string key = _config.GetValue<string>("WeatherApi:Key");
            url.Append(@$"?key={key}&q={location}&days={days}");

            Rootobject? obj;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url.ToString()))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    obj = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }
            if(obj?.Location == null)
            {
                return null;
            }
            return obj;
        }
    }
}
