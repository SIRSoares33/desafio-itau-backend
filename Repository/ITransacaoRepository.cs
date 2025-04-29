using DesafioItau.Models;

namespace DesafioItau.Repository
{
    /// <summary>
    /// Interface para o repositório de transações, responsável por gerenciar as operações relacionadas às transações.
    /// </summary>
    public interface ITransacaoRepository
    {
        /// <summary>
        /// Adiciona uma nova transação ao repositório.
        /// </summary>
        /// <param name="transacao">A transação a ser adicionada.</param>
        void AddTransacao(Transacao transacao);

        /// <summary>
        /// Remove todas as transações do repositório.
        /// </summary>
        void ClearTransacoes();

        /// <summary>
        /// Obtém a lista de transações realizadas nos últimos 60 segundos.
        /// </summary>
        /// <returns>Uma lista de transações realizadas nos últimos 60 segundos ou null se não houver transações.</returns>
        List<Transacao>? GetTransacaosIn60Seconds();
    }
}