using DesafioItau.Factory.Statistic;
using DesafioItau.Models;
using DesafioItau.Models.Enums;
using DesafioItau.Services.Statistic.StatisticManager;


namespace DesafioItau.Services
{
    public class StatisticServiceManager(IStatisticFactory factory) : IStatisticServiceManager
    {
        #region IStatisticServiceManager Methods
        public StatisticModel GetStatisticModel(List<Transacao> transacaos)
        {
            var values = transacaos.Select(x => x.Valor).ToList();

            return new()
            {
                Count = transacaos.Count,
                Sum   = factory.GetStatisticService(EStatisctics.Sum).GetStatistica(values),
                Avg   = factory.GetStatisticService(EStatisctics.Average).GetStatistica(values),
                Max   = factory.GetStatisticService(EStatisctics.OrderMax).GetStatistica(values),
                Min   = factory.GetStatisticService(EStatisctics.OrderMin).GetStatistica(values)
            };
        }
        #endregion
    }
}