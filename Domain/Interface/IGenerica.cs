using System.Collections.Generic;

namespace Domain.Interface
{
    public interface IGenerica<T> where T : class
    {
        void Adicionar(T Objeto);
        void Atualizar(T Objeto);
        void Excluir(T Objeto);
        T ObterPorId(int Id);
        IList<T> Listar();

    }
}
