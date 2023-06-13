using AutoMapper;
using LevvaCoins.Data.Interfaces;
using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos;
using LevvaCoins.Logic.Interfaces;

namespace LevvaCoins.Logic.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _repository;
        private readonly IMapper _mapper;
        public TransacaoService(ITransacaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TransacaoDto Create(int userId, CreateTransacaoDto transacao)
        {

            var _transacao = _mapper.Map<Transacao>(transacao);
            _transacao.UserId = userId;
            _transacao.CreatedAt = DateTime.Now;
            var transactionDto = _repository.Create(_transacao);

            return _mapper.Map<TransacaoDto>(transactionDto);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public TransacaoDto Get(int Id)
        {
            var transacao = _mapper.Map<TransacaoDto>(_repository.Get(Id));
            return transacao;
        }

        public List<TransacaoDto> GetAll()
        {
            var transacaos = _mapper.Map<List<TransacaoDto>>(_repository.GetAll());
            return transacaos;
        }

        public List<TransacaoDto> SearchDescription(string search)
        {
            var transactions = _repository.SearchByDescription(search);
            return _mapper.Map<List<TransacaoDto>>(transactions);
        }

        public void Update(TransacaoDto transacao)
        {
            var _transacao = _mapper.Map<Transacao>(transacao);
            _repository.Update(_transacao);


        }
    }
}
