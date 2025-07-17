using System.Collections.Generic;
using ModelProject2;
namespace WeatherServiceInterface
{
    public interface IWeatherService
    {
        List<CityWeather> GetWeatherDetails();
        CityWeather? GetWeatherByCityCode(string CityCode);
    }
}
