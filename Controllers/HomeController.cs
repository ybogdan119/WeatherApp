using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using WeatherApp.Models;
using WeatherApp.Models.ViewModels;
using WeatherApp.Services;
using WeatherApp.Tools;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        IWeatherApiService _weatherService;
        public HomeController(IWeatherApiService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index(string location = "Kyiv")
        {
            Rootobject? obj = await _weatherService.GetForecastAsync(location);
            if(obj == null)
            {
                return RedirectToAction();
            }
            WeatherViewModel? weather = Mapper.MapWeather(obj);
            return View(weather);
        }

        public async Task<IActionResult> Detailed(string location, int day)
        {
            Rootobject? obj = await _weatherService.GetForecastAsync(location);
            if(obj == null)
            {
                return RedirectToAction("Index");
            }
            WeatherViewModel weather = Mapper.MapWeather(obj);
            ViewBag.Location = location;
            return View(weather.Forecast[day]);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}