using DesafioItau.Models.Enums;
using DesafioItau.Services;
using DesafioItau.Services.AverageStatisticService;
using DesafioItau.Services.OrderValueStatisticService;
using DesafioItau.Services.SumStatisticService;

namespace DesafioItau.Factory.Statistic
{
    public class StatisticFactory : IStatisticFactory
    {
        #region Attributes
        private readonly Dictionary<EStatisctics, Type> _mapValues;
        private readonly IServiceProvider _serviceProvider;
        #endregion

        #region Constructor
        public StatisticFactory(IServiceProvider serviceProvider)
        {
            _mapValues = new()
            {
                { EStatisctics.Sum,      typeof(ISumStatisticService)      },
                { EStatisctics.Average,  typeof(IAverageStatisticService)  },
                { EStatisctics.OrderMax, typeof(IOrderMaxStatisticService) },
                { EStatisctics.OrderMin, typeof(IOrderMinStatisticService) }
            };

            _serviceProvider = serviceProvider;
        }
        #endregion

        #region IStatisticFactory Methods
        public IStatisticService GetStatisticService(EStatisctics eStatisctics)
            => _mapValues.ContainsKey(eStatisctics) ? (IStatisticService)_serviceProvider.GetRequiredService(_mapValues[eStatisctics]) 
                : throw new Exception("Erro de chave");
        #endregion
    }
}