using LevvaCoins.Logic.Dtos;
using LevvaCoins.Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoins.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;
        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Create(UsuarioDto usuario)
        {
            _service.Create(usuario);
            return Created("", usuario);
        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioDto> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpGet]
        public ActionResult<List<UsuarioDto>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UsuarioDto usuario)
        {
            _service.Update(usuario);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok(); 
        }
        [HttpPost("auth")]
        [AllowAnonymous]
        public ActionResult<LoginDto> Login(LoginDto loginDto)
        {
            var login = _service.Login(loginDto); 
            if(login == null)
                return BadRequest("Usuário ou senha inválidos");
            return Ok(login);
        }
    }
}
