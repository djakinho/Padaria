using Padaria.Data.Interface;
using Padaria.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Padaria.Data.Repository
{
    public class BaseRepository<T> where T : class, IEntity
    {
        protected readonly Context contexto;
        public BaseRepository()
        {
            contexto = new Context();
        }

        public virtual void Adicionar(T entity)
        {
            contexto.Set<T>().Add(entity);
            contexto.SaveChanges();
        }

        public void Editar(T entity)
        {
            contexto.Set<T>().Update(entity);
            contexto.SaveChanges();
        }

        public T Selecionar(int id)
        {
            return contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> SelecionarTudo()
        {
            return contexto.Set<T>().ToList();
        }

        public void Apagar(int id)
        {
            var entity = Selecionar(id);
            contexto.Set<T>().Remove(entity);
            contexto.SaveChanges();
        }
    }
}