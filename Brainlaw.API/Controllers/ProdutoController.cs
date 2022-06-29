using Microsoft.AspNetCore.Mvc;
using Brainlaw.Application.DTO;
using Brainlaw.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace Brainlaw.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IApplicationServiceProduto applicationServiceProduto;

        public ProdutosController(IApplicationServiceProduto applicationServiceProduto)
        {
            this.applicationServiceProduto = applicationServiceProduto;
        }

        // GET ALL
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceProduto.GetAll());
        }

        // GET
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceProduto.GetById(id));
        }

        // POST
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDTO ProdutoDTO)
        {
            try
            {
                if (ProdutoDTO == null)
                    return NotFound();
                if (ProdutoDTO.Id == 0)
                    return Ok("Id inválido");
                
                applicationServiceProduto.Add(ProdutoDTO);
                return Ok("O produto foi cadastrado com sucesso!");
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT
        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDTO ProdutoDTO)
        {
            try
            {
                if (ProdutoDTO == null)
                    return NotFound();

                applicationServiceProduto.Update(ProdutoDTO);
                return Ok("O produto foi atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDTO ProdutoDTO)
        {
            try
            {
                if (ProdutoDTO == null)
                    return NotFound();
                if (ProdutoDTO.Id == 0)
                    return Ok("Id inválido");

                applicationServiceProduto.Remove(ProdutoDTO);
                return Ok("O produto foi removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}