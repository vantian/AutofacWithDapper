using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using Dependency_Injection_with_Autofac.Models;
using Dependency_Injection_with_Autofac.Interface;

namespace Dependency_Injection_with_Autofac.Services
{
    public class CustomersService : ICustomersService
    {
        SqlConnection _myCon;
        public CustomersService()
        {
            _myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString);
        }

        public IEnumerable<Customers> GetAll()
        {
            string query = "SELECT * FROM customers";
            var result = _myCon.Query<Customers>(query);
            return result;
        }
    }
}
