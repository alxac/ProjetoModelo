using System.Collections.Generic;
using Aplicacao.Interface;
using Domain.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoApp produtoApp;

        public ProdutoController(IProdutoApp _produtoApp)
        {
            produtoApp = _produtoApp;
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return produtoApp.Listar();
        }

        [HttpGet("{id}", Name = "Get")]
        public Produto Get(int id)
        {
            return produtoApp.ObterPorId(id);
        }

        [HttpPost]
        public void Post([FromBody] Produto value)
        {
            produtoApp.Adicionar(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Produto value)
        {
            produtoApp.Atualizar(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            produtoApp.Excluir(produtoApp.ObterPorId(id));
        }
    }
}
