using System;
using System.Collections.Generic;
using Airplane.Domain.Entities;

namespace Airplane.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(T obj);

        T Select(int id);

        IList<T> SelectAll();
    }
}
