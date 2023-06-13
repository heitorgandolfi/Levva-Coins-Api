using LevvaCoins.Logic.Dtos;

namespace LevvaCoins.Logic.Interfaces
{
    public interface IUsuarioService
    {
        void Create(UsuarioDto usuario);
        UsuarioDto Get(int Id);
        List<UsuarioDto> GetAll();
        void Update(UsuarioDto usuario);
        void Delete(int Id);
        LoginResponseDto Login(LoginDto login);
    }
}
