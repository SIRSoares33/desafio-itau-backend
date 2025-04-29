using DesafioItau.Models;

namespace DesafioItau.Services.Statistic.StatisticManager
{
    /// <summary>
    /// Interface para o gerenciador de serviços de estatísticas, responsável por consolidar e calcular os dados estatísticos com base em uma lista de transações.
    /// </summary>
    public interface IStatisticServiceManager
    {
        /// <summary>
        /// Gera um modelo estatístico consolidado com base em uma lista de transações.
        /// </summary>
        /// <param name="transacaos">A lista de transações a ser utilizada no cálculo das estatísticas.</param>
        /// <returns>Um objeto <see cref="StatisticModel"/> contendo os dados estatísticos calculados.</returns>
        StatisticModel GetStatisticModel(List<Transacao> transacaos);
    }
}