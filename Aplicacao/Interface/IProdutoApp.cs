using Domain.Entidades;

namespace Aplicacao.Interface
{
    public interface IProdutoApp : IGenericaApp<Produto>
    {
        Produto AdicionaVerificandoNome(Produto produto);

    }
}
