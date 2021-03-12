using Padaria.Data;
using Padaria.Data.Interface;
using Padaria.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Minha1Conexao.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity
    {
        protected readonly Contexto _contexto;
        public BaseRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public virtual void Adicionar(T entity)
        {
            _contexto.Set<T>().Add(entity);
            _contexto.SaveChanges();
        }

        public void Editar(T entity)
        {
            _contexto.Set<T>().Update(entity);
            _contexto.SaveChanges();
        }

        public T Selecionar(int id)
        {
            return _contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> SelecionarTudo()
        {
            return _contexto.Set<T>().ToList();
        }

        public void Apagar(int id)
        {
            var entity = Selecionar(id);
            _contexto.Set<T>().Remove(entity);
            _contexto.SaveChanges();
        }
        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}