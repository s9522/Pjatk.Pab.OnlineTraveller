﻿using System;
using System.Collections.Generic;
using Pjatk.Pab.OnlineTraveller.Core.Interfaces;
using Pjatk.Pab.OnlineTraveller.Core.Interfaces.Repositories;
using System.Linq;
using System.Data.Entity;
using Pjatk.Pab.OnlineTraveller.Core.Domain.Entities;


namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
          where T : EntityBase<int>, IAggregateRoot
    {
        protected DbContext _context;
        protected readonly IDbSet<T> _dbset;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {

            return _dbset.AsEnumerable<T>();
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }
    }
}