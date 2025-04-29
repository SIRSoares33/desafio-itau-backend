namespace DesafioItau.Services.OrderValueStatisticService
{
    public class OrderMaxStatisticService : IOrderMaxStatisticService
    {
        public decimal GetStatistica(List<decimal> values)
            => values.Max();
    }
}