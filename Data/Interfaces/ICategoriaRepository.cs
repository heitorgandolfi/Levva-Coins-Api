using LevvaCoins.Domain.Models;

namespace LevvaCoins.Data.Interfaces
{
    public interface ICategoriaRepository
    {
        Categoria Create(Categoria categoria);
        Categoria Get(int id);
        List<Categoria> GetAll();
        void Update(Categoria categoria);
        void Delete(int Id);

    }
}
