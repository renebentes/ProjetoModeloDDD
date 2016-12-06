using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Contracts
{
    public interface ICustomerAppService : IAppServiceBase<Customer>
    {
        IEnumerable<Customer> GetSpecialsCustomers();
    }
}