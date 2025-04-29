using DesafioItau.Models;

namespace DesafioItau.Repository
{
    public class TransacaoInMemoryRepository : ITransacaoRepository
    {
        #region Context
        private static List<Transacao> _transacoes = [];
        #endregion

        #region ITransacaoRepository Methods
        public void AddTransacao(Transacao transacao)
            => _transacoes.Add(transacao);
        public void ClearTransacoes()
            => _transacoes.Clear();
        public List<Transacao>? GetTransacaosIn60Seconds() 
        {
            var transacaoIn60Seconds = _transacoes.Where(x => x.DataHora >= DateTime.Now.AddSeconds(-60)).ToList();

            if (transacaoIn60Seconds.Any() is false)
                return null;

            return transacaoIn60Seconds;
        }
        #endregion
    }
}