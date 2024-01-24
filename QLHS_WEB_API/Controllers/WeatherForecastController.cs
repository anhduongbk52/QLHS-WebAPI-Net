using Microsoft.AspNetCore.Mvc;
using Model.Models;

namespace QLHS_WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly EemcdrContext _EemcdrContext;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,EemcdrContext eemcdrContext)
        {
            _logger = logger;
            _EemcdrContext = eemcdrContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<dynamic> Get()
        {            
            return _EemcdrContext.Users.ToArray();
        }
    }
}
