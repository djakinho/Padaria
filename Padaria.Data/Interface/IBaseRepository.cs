using System;
using System.Collections.Generic;
using System.Text;
using Padaria.Domain;


namespace Padaria.Data.Interface
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        void Adicionar(T entity);
        void Editar(T entity);
        T Selecionar(int id);
        List<T> SelecionarTudo();
        void Apagar(int id);
        void Dispose();
    }
}
