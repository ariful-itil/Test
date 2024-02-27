
using ClassLibrary.DTOs;

namespace ClassLibrary.Contracts
{
    public interface IWeather
    {
        Task<WeatherForecast[]> GetWeatherForecast();
    }
}
