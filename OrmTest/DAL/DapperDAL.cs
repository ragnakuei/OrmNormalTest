using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Dapper;
using OrmTest.EF;

namespace OrmTest.DAL
{
    internal class DapperDAL : IDAL
    {
        private static string _connectionString;

        static DapperDAL()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["dbConn"]
                                                    .ConnectionString;
        }

        public List<Customer> Get()
        {
            using ( SqlConnection conn = new SqlConnection(_connectionString) )
            {
                var result = conn.Query<Customer>(
                                                  "SELECT * FROM Customers"
                                                  ,commandType: CommandType.Text
                                                  )
                                 .ToList();
                return result;
            }
        }
    }
}