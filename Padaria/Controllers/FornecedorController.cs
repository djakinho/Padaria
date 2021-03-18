﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Data.Repository;
using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Estoquista,Administrador")]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorRepository _repo;
        public FornecedorController(IFornecedorRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.SelecionarTudo());
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_repo.Selecionar(id));
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Fornecedor fornecedor)
        {
            try
            {
                _repo.Adicionar(fornecedor);
                return Ok(_repo.SelecionarTudo());
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Fornecedor fornecedor)
        {
            try
            {
                _repo.Editar(fornecedor);
                return Ok(_repo.SelecionarTudo());
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
                return Ok(_repo.SelecionarTudo());
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
