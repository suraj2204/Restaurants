using Microsoft.AspNetCore.Mvc;

namespace Restaurants.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherForecastsService _weatherForecastsService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastsService weatherForecastsService)
        {
            _logger = logger;
            _weatherForecastsService = weatherForecastsService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var result = _weatherForecastsService.Get();
            return result;
        }
    }
}
