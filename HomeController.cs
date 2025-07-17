using Microsoft.AspNetCore.Mvc;
using WeatherServiceInterface;
using ModelProject2;
namespace CRUDExample
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService;
        
        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
        [Route("/")]
        public JsonResult AllCities()
        {
            List<CityWeather> ct = _weatherService.GetWeatherDetails();
            
                return new JsonResult(ct);
            
        }
        [Route("/weather/{cityCode}")]
        public JsonResult City(string cityCode)
        {
            CityWeather? ct = _weatherService.GetWeatherByCityCode(cityCode);
            
            return new JsonResult(ct);
        }
    }
}
