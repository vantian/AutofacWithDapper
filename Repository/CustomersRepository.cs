using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using Dependency_Injection_with_Autofac.Models;

namespace Dependency_Injection_with_Autofac.Repository
{
    public class CustomersRepository
    {
        SqlConnection _myCon;
        public CustomersRepository()
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
