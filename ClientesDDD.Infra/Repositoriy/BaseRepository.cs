using ClientesDDD.Domain.Interfaces;
using ClientesDDD.Infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientesDDD.Infra.Repositoriy
{
    public class BaseRepository<T> : IBase<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<ClientesDbContext> _optionsBuilder;

        public BaseRepository()
        {
            _optionsBuilder = new DbContextOptions<ClientesDbContext>();
        }

        public void Adicionar(T obj)
        {
            using (var db = new ClientesDbContext(_optionsBuilder))
            {
                try
                {
                    db.Set<T>().Add(obj);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public T RecuperarPorId(Guid id)
        {
            using (var db = new ClientesDbContext(_optionsBuilder))
            {
                return db.Set<T>().Find(id);
            }
        }

        public void Atualizar(T obj)
        {
            using (var db = new ClientesDbContext(_optionsBuilder))
            {
                db.Set<T>().Update(obj);
                db.SaveChanges();
            }
        }

        public void Excluir(T obj)
        {
            using (var db = new ClientesDbContext(_optionsBuilder))
            {
                db.Set<T>().Remove(obj);
                db.SaveChanges();
            }
        }

        public IList<T> Listar()
        {
            using (var db = new ClientesDbContext(_optionsBuilder))
            {
                return db.Set<T>().AsNoTracking().ToList();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}

