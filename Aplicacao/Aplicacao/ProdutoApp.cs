using System.Collections.Generic;
using Aplicacao.Interface;
using Domain.Entidades;
using Domain.Interface;

namespace Aplicacao.Aplicacao
{
    public class ProdutoApp : IProdutoApp
    {
        IProduto _iProduto;

        public ProdutoApp(IProduto iProduto)
        {
            _iProduto = iProduto;
        }
        public void Adicionar(Produto Objeto)
        {
            _iProduto.Adicionar(Objeto);
        }

        public void Atualizar(Produto Objeto)
        {
            _iProduto.Atualizar(Objeto);
        }

        public void Excluir(Produto Objeto)
        {
            _iProduto.Excluir(Objeto);
        }

        public IList<Produto> Listar()
        {
            return _iProduto.Listar();
        }

        public Produto ObterPorId(int Id)
        {
            return _iProduto.ObterPorId(Id);
        }
    }
}
