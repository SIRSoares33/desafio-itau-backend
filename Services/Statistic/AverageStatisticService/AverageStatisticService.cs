
namespace DesafioItau.Services.AverageStatisticService
{
    public class AverageStatisticService : IAverageStatisticService
    {
        public decimal GetStatistica(List<decimal> values)
            => values.Average();
    }
}