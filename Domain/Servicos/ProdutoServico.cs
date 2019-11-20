using Domain.Entidades;
using Domain.Interface;

namespace Domain.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProduto _iProduto;

        public ProdutoServico(IProduto iProduto)
        {
            _iProduto = iProduto;
        }

        public Produto AdicionaVerificandoNome(Produto produto)
        {
            var existe = _iProduto.VerificaProdutoExistente(produto);
            produto.Nome = TransformaMaiusculo(produto.Nome);

            if (!existe)
            {
                _iProduto.Adicionar(produto);
            }
            else
            {
                produto.Notificacoes.Add(
                    new Notifica.Notifica
                    {
                        NomeProdriedade = "Nome",
                        Mensagem = "Produto já existe com esse nome"
                    });
            }
            return produto;
        }

        public string TransformaMaiusculo(string nome)
        {
            return nome.ToUpper();
        }
    }
}
