using DynaTech.Weather.Domain.Models;

namespace DynaTech.Weather.Infrastructure.Interfaces
{
    public interface IForecastRepository
    {
        IEnumerable<Forecast> GetForecasts();
    }
}
