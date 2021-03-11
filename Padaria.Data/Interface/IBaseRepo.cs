using System;
using System.Collections.Generic;
using System.Text;
using Padaria.Domain;


namespace Padaria.Data.Interface
{
    public interface IBaseRepo<T> where T : class, IEntity
    {

    }
}
