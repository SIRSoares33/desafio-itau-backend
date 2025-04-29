
namespace DesafioItau.Services.SumStatisticService
{
    public class SumStatisticService : ISumStatisticService
    {
        public decimal GetStatistica(List<decimal> values)
            => values.Sum();
    }
}