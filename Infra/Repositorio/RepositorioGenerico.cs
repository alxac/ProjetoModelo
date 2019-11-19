using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Interface;
using Infra.Configuracao;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositorio
{
    public class RepositorioGenerico<T> : InterfaceGenerica<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<Contexto> _optionBuilder;

        public RepositorioGenerico()
        {
            _optionBuilder = new DbContextOptions<Contexto>();
        }
        public void Adicionar(T Objeto)
        {
            using (var banco = new Contexto(_optionBuilder))
            {
                banco.Set<T>().Add(Objeto);
                banco.SaveChanges();
            }
        }

        public void Atualizar(T Objeto)
        {
            using (var banco = new Contexto(_optionBuilder))
            {
                banco.Set<T>().Update(Objeto);
                banco.SaveChanges();
            }
        }

        public void Excluir(T Objeto)
        {
            using (var banco = new Contexto(_optionBuilder))
            {
                banco.Set<T>().Remove(Objeto);
                banco.SaveChanges();
            }
        }

        public IList<T> Listar()
        {
            using (var banco = new Contexto(_optionBuilder))
            {
                return banco.Set<T>().AsNoTracking().ToList();
            }
        }

        public T ObterPorId(int Id)
        {
            using (var banco = new Contexto(_optionBuilder))
            {
                return banco.Set<T>().Find(Id);
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
