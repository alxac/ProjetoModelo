using Aplicacao.Aplicacao;
using Aplicacao.Interface;
using Domain.Interface;
using Domain.Servicos;
using Infra.Repositorio;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC
{
    public class RegisterContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddSingleton(typeof(IGenerica<>), typeof(RepositorioGenerico<>));
            services.AddSingleton<IProduto, RepositorioProduto>();
            services.AddSingleton<IProdutoApp, ProdutoApp>();
            services.AddSingleton<IProdutoServico, ProdutoServico>();
        }

    }
}
