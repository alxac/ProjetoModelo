using Domain.Entidades;

namespace Domain.Interface
{
    public interface IProduto : IGenerica<Produto>
    {
        bool VerificaProdutoExistente(Produto produto);
    }
}
