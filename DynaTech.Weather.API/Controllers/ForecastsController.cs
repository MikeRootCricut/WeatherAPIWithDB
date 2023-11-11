using DynaTech.Weather.Domain.Interfaces;
using DynaTech.Weather.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynaTech.Weather.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForecastsController : ControllerBase
    {
        private readonly ILogger<ForecastsController> _logger;
        private readonly IForecastsService _forecastsService;

        public ForecastsController(
            ILogger<ForecastsController> logger,
            IForecastsService forecastsService)
        {
            _logger = logger;
            _forecastsService = forecastsService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Forecast> Get()
        {
            return _forecastsService.GetForecasts();
        }
    }
}