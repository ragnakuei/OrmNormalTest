using System;
using OrmTest.DAL;

namespace OrmTestConsole
{
    internal class TestClass
    {
        private IDAL _dapperDAL;
        private IDAL _efDAL;

        public TestClass()
        {
            _dapperDAL = new DapperDAL();
            _dapperDAL.Get();

            _efDAL     = new EfDAL();
            _efDAL.Get();
        }

        internal void Dapper()
        {
            _dapperDAL = new DapperDAL();
            _dapperDAL.Get();
        }

        internal void EF()
        {
            _efDAL     = new EfDAL();
            _efDAL.Get();
        }
    }
}