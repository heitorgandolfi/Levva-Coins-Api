using AutoMapper;
using LevvaCoins.Data.Interfaces;
using LevvaCoins.Data.Repositories;
using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos;
using LevvaCoins.Logic.Interfaces;

namespace LevvaCoins.Logic.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;
        public CategoriaService(ICategoriaRepository repository, IMapper mapper)
        {
            _repository = repository; 
            _mapper = mapper;

           
        }
        public CategoriaDto Create(CreateCategoriaDto categoria)
        {
            var _categoria = _mapper.Map<Categoria>(categoria);

            return _mapper.Map<CategoriaDto>(_repository.Create(_categoria));
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public CategoriaDto Get(int Id)
        {
            var categoria = _mapper.Map<CategoriaDto>(_repository.Get(Id));
            return categoria;
        }

        public List<CategoriaDto> GetAll()
        {
            var categorias = _mapper.Map<List<CategoriaDto>>(_repository.GetAll());
            return categorias;
        }

        public void Update(CategoriaDto categoria)
        {
            var _categoria = _mapper.Map<Categoria>(categoria);
            _repository.Update(_categoria);
        }
    }
}
