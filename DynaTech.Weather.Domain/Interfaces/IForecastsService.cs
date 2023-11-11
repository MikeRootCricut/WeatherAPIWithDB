using DynaTech.Weather.Domain.Models;

namespace DynaTech.Weather.Domain.Interfaces
{
    public interface IForecastsService
    {
        IEnumerable<Forecast> GetForecasts();
    }
}
