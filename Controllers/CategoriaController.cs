using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos;
using LevvaCoins.Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoins.Controllers
{
    [Authorize]
    [Route("api/category")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _service;
        public CategoriaController(ICategoriaService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Create(CreateCategoriaDto categoria)
        {
            var categ = _service.Create(categoria);
            return Created("", categ);
        }

        [HttpGet("{id}")]
        public ActionResult<CategoriaDto> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpGet]
        public ActionResult<List<CategoriaDto>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoriaDto categoria)
        {
            _service.Update(categoria);
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