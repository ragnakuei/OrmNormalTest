using System.Collections.Generic;
using OrmTest.EF;

namespace OrmTest.DAL
{
    public interface IDAL
    {
        List<Customer> Get();
    }
}