namespace DesafioItau.Services
{
    /// <summary>
    /// Interface para serviços de estatísticas, responsável por calcular valores estatísticos com base em uma lista de números decimais.
    /// </summary>
    public interface IStatisticService
    {
        /// <summary>
        /// Calcula um valor estatístico com base em uma lista de valores decimais.
        /// </summary>
        /// <param name="values">A lista de valores decimais a ser utilizada no cálculo.</param>
        /// <returns>O valor estatístico calculado.</returns>
        decimal GetStatistica(List<decimal> values);
    }
}