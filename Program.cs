using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependency_Injection_with_Autofac.Repository;
using Dependency_Injection_with_Autofac.Models;

namespace Dependency_Injection_with_Autofac
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFunction myfunc = new MyFunction();
            var myCustomersList = myfunc.GetAllCustomers();
            foreach (var cust in myCustomersList.ToList())
            {
                Console.WriteLine(cust.ContactName);
            }
        }
    }

    public class MyFunction
    {
        private CustomersRepository _custRepo;
        public MyFunction()
        {
            _custRepo = new CustomersRepository();

        }
        
        public IEnumerable<Customers> GetAllCustomers()
        {
            return _custRepo.GetAll();
        }
    }
}
