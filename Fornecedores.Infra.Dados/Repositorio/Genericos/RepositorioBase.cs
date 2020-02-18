using Fornecedores.Infra.Dados.Config;
using FornecedoresDDD.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fornecedores.Infra.Dados.Repositorio.Genericos
{
    public class RepositorioBase<T> : IBase<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<FornecedoresDbContext> _optionsBuilder;

        public RepositorioBase()
        {
            _optionsBuilder = new DbContextOptions<FornecedoresDbContext>();
        }

        public void Adicionar(T obj)
        {
            using (var db = new FornecedoresDbContext(_optionsBuilder))
            {
                db.Set<T>().Add(obj);
                db.SaveChanges();
            }
        }

        public void Atualizar(T obj)
        {
            using (var db = new FornecedoresDbContext(_optionsBuilder))
            {
                db.Set<T>().Update(obj);
                db.SaveChanges();
            }
        }

        public void Excluir(T obj)
        {
            using (var db = new FornecedoresDbContext(_optionsBuilder))
            {
                db.Set<T>().Remove(obj);
                db.SaveChanges();
            }
        }

        public IList<T> Listar()
        {
            using (var db = new FornecedoresDbContext(_optionsBuilder))
            {
                return db.Set<T>().AsNoTracking().ToList();
            }
        }

        public T RecuperarPorId(Guid id)
        {
            using (var db = new FornecedoresDbContext(_optionsBuilder))
            {
                return db.Set<T>().Find(id);
            }
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
