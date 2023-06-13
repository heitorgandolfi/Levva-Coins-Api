using LevvaCoins.Logic.Dtos;

namespace LevvaCoins.Logic.Interfaces
{
    public interface ICategoriaService
    {
        CategoriaDto Create(CreateCategoriaDto categoria);
        CategoriaDto Get(int Id);
        List<CategoriaDto> GetAll();
        void Update(CategoriaDto categoria);
        void Delete(int Id);
    }
}
