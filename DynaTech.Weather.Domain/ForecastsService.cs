using DynaTech.Weather.Domain.Interfaces;
using DynaTech.Weather.Domain.Models;
using DynaTech.Weather.Infrastructure.Interfaces;

namespace DynaTech.Weather.Domain
{
    public class ForecastsService : IForecastsService
    {
        private readonly IForecastRepository _forecastRepository;

        public ForecastsService(IForecastRepository forecastRepository) 
        { 
            _forecastRepository = forecastRepository;
        }

        public IEnumerable<Forecast> GetForecasts()
        {
            return _forecastRepository.GetForecasts();
        }
        
    }
}
