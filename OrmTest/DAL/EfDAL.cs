using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OrmTest.EF;

namespace OrmTest.DAL
{
    public class EfDAL : IDisposable , IDAL
    {
        private bool isDisposed = false;

        private readonly NorthwindEntities _dbContext;

        public EfDAL() : this(new NorthwindEntities()) { } 
        
        public EfDAL(NorthwindEntities dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Configuration.AutoDetectChangesEnabled = false;
            //_dbContext.Configuration.ProxyCreationEnabled  = false;
            //_dbContext.Configuration.LazyLoadingEnabled   = false;
        }

        public List<Customer> Get()
        {
            var result = _dbContext.Customers
                                   .AsNoTracking()
                                   .ToList();
            return result;
        }

        public void Dispose()
        {
            if ( isDisposed == false )
            {
                _dbContext?.Dispose();
                isDisposed = true;
            }
        }

    }
}
