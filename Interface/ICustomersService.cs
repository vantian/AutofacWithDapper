using System.Collections.Generic;
using Dependency_Injection_with_Autofac.Models;

namespace Dependency_Injection_with_Autofac.Interface
{
    public interface ICustomersService
    {
        IEnumerable<Customers> GetAll();
    }
}
