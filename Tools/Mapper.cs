using Microsoft.JSInterop.Implementation;
using WeatherApp.Models;
using WeatherApp.Models.ViewModels;

namespace WeatherApp.Tools
{
    public static class Mapper
    {
        public static WeatherViewModel MapWeather(Rootobject obj)
        {
            return new WeatherViewModel()
            {
                Current = new CurrentViewModel()
                {
                    Time = obj.Location.Localtime,
                    Temperature = obj.Current.Temp_c
                },
                Forecast = MapForecast(obj.forecast.Forecastday),
                Location = obj.Location.Name
            };

        }
        private static ForecastDayViewModel[] MapForecast(Forecastday[] forecastdays)
        {
            var result = new ForecastDayViewModel[forecastdays.Length];

            for (int i = 0; i < forecastdays.Length; i++)
            {
                result[i] = new ForecastDayViewModel()
                {
                    Date = forecastdays[i].Date,
                    MinTemperature = forecastdays[i].Day.Mintemp_c,
                    MaxTemperature = forecastdays[i].Day.Maxtemp_c,
                    Hours = MapHours(forecastdays[i].Hour)
                };
            }
            return result;
        }
        
        private static HourViewModel[] MapHours(Hour[] hours) 
        {
            var result = new HourViewModel[hours.Length];

            for(int i = 0;i < hours.Length; i++)
            {
                result[i] = new HourViewModel()
                {
                    Temperature = hours[i].Temp_c,
                    Time = hours[i].Time
                };
            }
            return result;
        }
    }
}
