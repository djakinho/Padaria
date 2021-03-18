﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Data.Repository;
using Padaria.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrador")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repo;
        public UsuarioController(IUsuarioRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get([FromQuery]string email, [FromQuery]string nome)
        {
            try
            {
                if (!string.IsNullOrEmpty(email) && string.IsNullOrEmpty(nome))
                {
                    return Ok(_repo.SelectPorEmail(email).OrderBy(a => a.Nome));
                }
                else if (string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(nome))
                {
                    return Ok(_repo.SelectPorNome(nome).OrderBy(a => a.Nome));
                }
                else if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(nome))
                {
                    var usuariosPorEmail = _repo.SelectPorEmail(email);
                    var usuariosPorNome = _repo.SelectPorNome(nome);
                    return Ok(usuariosPorEmail.Union(usuariosPorNome).OrderBy(a => a.Nome));
                } else {
                    return Ok(_repo.SelecionarTudo());
                }
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, "Tivemos um problema");
            }

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id.ToString()))
                {
                    return Ok(_repo.SelecionarTudo());
                }
                else if (_repo.Selecionar(id) == null)
                {
                    return NotFound(id);
                }
                else
                {
                    return Ok(_repo.Selecionar(id));
                }
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario Usuario)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Usuario.Nome)
                    || string.IsNullOrWhiteSpace(Usuario.Email)
                    || string.IsNullOrWhiteSpace(Usuario.Senha)
                    || string.IsNullOrWhiteSpace(Usuario.CPF))
                {
                    return BadRequest("Todos os campos precisam ser preenchidos");
                }
                else if (Usuario.IdPerfilUsuario <= 0 || Usuario.IdPerfilUsuario > 4)
                {
                    return BadRequest("O IdPerfilUsuario precisa ser válido");
                }

                _repo.Adicionar(Usuario);
                return Ok("Operação Concluida");
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Usuario Usuario)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Usuario.Nome)
                    || string.IsNullOrWhiteSpace(Usuario.Email)
                    || string.IsNullOrWhiteSpace(Usuario.Senha)
                    || string.IsNullOrWhiteSpace(Usuario.CPF))
                {
                    return BadRequest("Todos os campos precisam ser preenchidos");
                }
                else if (Usuario.IdPerfilUsuario <= 0 || Usuario.IdPerfilUsuario > 4)
                {
                    return BadRequest("O IdPerfilUsuario precisa ser válido");
                }

                _repo.Editar(Usuario);
                return Ok("Operação Concluida");
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _repo.Apagar(id);
                return Ok("Operação Concluida");
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }

        }
    }
}
