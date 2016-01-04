using System.Collections.Generic;
using Dependency_Injection_with_Autofac.Models;
using Dependency_Injection_with_Autofac.Interface;

namespace Dependency_Injection_with_Autofac.Services
{
    public class CustomersService : ICustomersService
    {
        public IEnumerable<Customers> GetAll()
        {
            return new List<Customers>() {
                new Customers() { ContactName="Bruce Wayne", City =  "Gotham", CompanyName ="Wayne Enterprise" },
                new Customers() { ContactName="Clark Kent", City =  "Metropolis", CompanyName ="Dialy Bugle" },
                new Customers() { ContactName="Oliver Queen", City =  "Star City", CompanyName ="Queen Industries" }
            };
        }
    }
}
