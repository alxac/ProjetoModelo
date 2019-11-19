using Domain.Entidades;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioProduto : RepositorioGenerico<Produto>, IProduto
    {
    }
}
