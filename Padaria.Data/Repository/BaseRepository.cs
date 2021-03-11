using Padaria.Data.Interface;
using Padaria.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Repository
{
    public class BaseRepository<T> : IBaseRepo<T> where T : class, IEntity
    {
        protected readonly Contexto _contexto;
        public BaseRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
