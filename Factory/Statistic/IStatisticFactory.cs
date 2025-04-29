using DesafioItau.Models.Enums;
using DesafioItau.Services;

namespace DesafioItau.Factory.Statistic
{
    /// <summary>
    /// Interface para a fábrica de serviços de estatísticas, responsável por fornecer a implementação apropriada de um serviço de estatística com base no tipo especificado.
    /// </summary>
    public interface IStatisticFactory
    {
        /// <summary>
        /// Obtém a implementação de um serviço de estatística com base no tipo especificado.
        /// </summary>
        /// <param name="eStatisctics">O tipo de estatística desejado.</param>
        /// <returns>Uma instância de <see cref="IStatisticService"/> correspondente ao tipo especificado.</returns>
        IStatisticService GetStatisticService(EStatisctics eStatisctics);
    }
}