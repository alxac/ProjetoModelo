using Domain.Entidades;
using Domain.Interface;
using Infra.Configuracao;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infra.Repositorio
{
    public class RepositorioProduto : RepositorioGenerico<Produto>, IProduto
    {
        private readonly DbContextOptions<Contexto> _optionBuilder;

        public RepositorioProduto()
        {
            _optionBuilder = new DbContextOptions<Contexto>();
        }
        public bool VerificaProdutoExistente(Produto produto)
        {
            using (var banco = new Contexto(_optionBuilder))
            {
                return banco.Produto.Where(p => p.Nome.ToUpper() == produto.Nome.ToUpper())
                    .Select(p => p.Nome).Any();
            }
        }
    }
}
