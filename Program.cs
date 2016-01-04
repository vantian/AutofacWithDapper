using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using Dependency_Injection_with_Autofac.Interface;
using Dependency_Injection_with_Autofac.Models;
using Dependency_Injection_with_Autofac.Services;

namespace Dependency_Injection_with_Autofac
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            //Autofac Register component
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<CustomersService>().As<ICustomersService>();
            builder.RegisterType<MyApplicationLogic>().As<MyApplicationLogic>();

            //build component into Autofac container
            Container = builder.Build();

            //this is smilliar to MyApplicationLogic application = new MyApplicationLogic();
            MyApplicationLogic application = Container.Resolve<MyApplicationLogic>();

            //Get customer data from database
            IEnumerable<Customers> myCustomersList = application.GetAllCustomers();

            foreach (Customers cust in myCustomersList.ToList())
            {
                Console.WriteLine(String.Format("Name: {0} - Company: {1}", cust.ContactName, cust.CompanyName));
            }
        }

        
    }

    /// <summary>
    /// Write some logic to get data using IoC structure
    /// we're using separate class because Main(string[] args) is a static class
    /// </summary>
    public class MyApplicationLogic
    {
        private readonly ICustomersService _custService;
        public MyApplicationLogic(ICustomersService CustService)
        {
            _custService = CustService;
        }

        public IEnumerable<Customers> GetAllCustomers()
        {
            Console.WriteLine("Code injected!");
            return this._custService.GetAll();
        }
    }
}
