using System.Collections.Generic;
using Aplicacao.Interface;
using Domain.Entidades;
using Domain.Interface;

namespace Aplicacao.Aplicacao
{
    public class ProdutoApp : IProdutoApp
    {
        IProduto _iProduto;
        IProdutoServico _iProdutoServ;

        public ProdutoApp(IProduto iProduto, IProdutoServico iProdutoServ)
        {
            _iProduto = iProduto;
            _iProdutoServ = iProdutoServ;
        }
        public void Adicionar(Produto Objeto)
        {
            _iProduto.Adicionar(Objeto);
        }

        public Produto AdicionaVerificandoNome(Produto produto)
        {
            return _iProdutoServ.AdicionaVerificandoNome(produto);
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
