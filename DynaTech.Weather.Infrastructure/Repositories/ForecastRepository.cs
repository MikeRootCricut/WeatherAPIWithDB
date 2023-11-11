using AutoMapper;
using Dapper;
using DynaTech.Weather.Domain.Models;
using DynaTech.Weather.Infrastructure.Dtos;
using DynaTech.Weather.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace DynaTech.Weather.Infrastructure.Repositories
{
    public class ForecastRepository : IForecastRepository
    {
        private readonly IDatabaseConnectionFactory _databaseConnectionFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<ForecastRepository> _logger;

        public ForecastRepository(
            IDatabaseConnectionFactory databaseConnectionFactory,
            IMapper mapper,
            ILogger<ForecastRepository> logger)
        {
            _databaseConnectionFactory = databaseConnectionFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<Forecast> GetForecasts()
        {
            try
            {
                using (var connection = _databaseConnectionFactory.GetWeatherDbConnection())
                {
                    var result = connection.Query<ForecastDto>("SELECT * FROM dbo.Forecasts");
                    var fromSource = _mapper.Map<IEnumerable<Forecast>>(result);
                    return fromSource;
                }
            }
            catch (Exception ex) 
            {
                _logger.LogError($"Error on {nameof(GetForecasts)} exception message: {ex.Message}");
                throw;
            }
        }
    }
}
