using System.Collections.Generic;
using OrmTest.EF;

namespace OrmTest.DAL
{
    internal interface IDAL
    {
        List<Customer> Get();
    }
}