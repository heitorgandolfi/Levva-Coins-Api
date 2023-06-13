using AutoMapper;
using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos;

namespace LevvaCoins.Logic.MapperProfiles
{
    public class DefaultMapper : Profile
    {
        public DefaultMapper()
        {
          CreateMap<UsuarioDto, Usuario>().ReverseMap();
          CreateMap<TransacaoDto, Transacao>().ReverseMap();
          CreateMap<CreateTransacaoDto, Transacao>().ReverseMap();
          CreateMap<CategoriaDto, Categoria>().ReverseMap();
          CreateMap<CreateCategoriaDto, Categoria>().ReverseMap();
        }
    }
}
