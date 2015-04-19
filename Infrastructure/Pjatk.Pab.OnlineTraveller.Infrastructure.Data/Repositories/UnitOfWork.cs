﻿using System;
using System.Data.Entity;
using Pjatk.Pab.OnlineTraveller.Core.Interfaces.Repositories;

namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Data.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {

        private DbContext _dbContext;


        public UnitOfWork(DbContext context)
        {

            _dbContext = context;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }
    }
}