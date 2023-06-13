using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos;
using LevvaCoins.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoins.Controllers
{
    [Route("api/transaction")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private readonly ITransacaoService _service;
        private readonly ICategoriaService _categoriaService;
        public TransacaoController(ITransacaoService service, ICategoriaService categoriaService)
        {
            _service = service;
            _categoriaService = categoriaService;
        }
        [HttpPost]
        public IActionResult Create(CreateTransacaoDto transacao)
        {
            var userId = User.Identity!.Name;

            var transaction =  _service.Create(Convert.ToInt32(userId),transacao);
            var cateory = _categoriaService.Get(transacao.CategoryId);

            transaction.Category = cateory;
            return Created("", transaction);
        }

        [HttpGet("{id}")]
        public ActionResult<TransacaoDto> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpGet]
        public ActionResult<List<TransacaoDto>> GetAll([FromQuery] string? search)
        {
            if(search == null) return _service.GetAll();

            return _service.SearchDescription(search);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, TransacaoDto transacao)
        {
            _service.Update(transacao);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
