using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Pjatk.Pab.OnlineTraveller.Core.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : IAggregateRoot
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}