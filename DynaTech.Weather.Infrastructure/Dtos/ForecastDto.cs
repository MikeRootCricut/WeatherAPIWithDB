namespace DynaTech.Weather.Infrastructure.Dtos
{
    public class ForecastDto
    {
        public int ForecastId { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public int ForecastSummaryTypeId { get; set; }
    }
}
