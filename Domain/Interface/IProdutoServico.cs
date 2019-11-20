using Domain.Entidades;

namespace Domain.Interface
{
    public interface IProdutoServico
    {
        Produto AdicionaVerificandoNome(Produto produto);

        string TransformaMaiusculo(string nome);

    }
}
