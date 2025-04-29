namespace DesafioItau.Services.OrderValueStatisticService
{
    public class OrderMinStatisticService : IOrderMinStatisticService
    {
        public decimal GetStatistica(List<decimal> values)
            => values.Min();
    }
}