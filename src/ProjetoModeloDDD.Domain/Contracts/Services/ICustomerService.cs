using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Contracts.Services
{
    public interface ICustomerService : IServiceBase<Customer>
    {
        IEnumerable<Customer> GetSpecialsCustomers(IEnumerable<Customer> customers);
    }
}