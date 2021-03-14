using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using Padaria.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public HomeController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        // POST api/<HomeController>
        [HttpPost("login")]
        public IActionResult Login([FromBody] Usuario usuarioDto)
        {
            try
            {
                if (string.IsNullOrEmpty(usuarioDto.Nome) || string.IsNullOrEmpty(usuarioDto.Senha))
                {
                    return BadRequest("Você deve prover um nome e uma senha");
                }
                var usuario = _usuarioRepository.SelecionarPorNomeESenha(usuarioDto.Nome, usuarioDto.Senha);
                if (usuario == null)
                {
                    return NotFound("Nome e/ou senha não encontrados");
                }
                var token = TokenService.GerarToken(usuario);
                return Ok(token);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um problema");
                throw;
            }
        }
    }
}
