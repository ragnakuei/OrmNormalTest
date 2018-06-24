using System;
using System.Collections.Generic;
using System.Linq;
using OrmTest.EF;

namespace OrmTest.DAL
{
    internal class EfDAL : IDisposable , IDAL
    {
        private bool isDisposed = false;

        private readonly NorthwindEntities _dbContext;

        public EfDAL() : this(new NorthwindEntities()) { } 
        
        public EfDAL(NorthwindEntities dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Configuration.AutoDetectChangesEnabled = false;
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
