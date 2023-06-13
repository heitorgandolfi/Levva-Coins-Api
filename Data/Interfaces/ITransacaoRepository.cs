using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos;

namespace LevvaCoins.Data.Interfaces
{
    public interface ITransacaoRepository
    {
        Transacao Create(Transacao transacao);
        Transacao Get(int Id);
        List<Transacao> GetAll();
        void Update(Transacao transacao);
        void Delete(int Id);

        ICollection<Transacao> SearchByDescription(string search);

    }
}
