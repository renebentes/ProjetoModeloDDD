using ProjetoModeloDDD.Domain.Contracts.Repositories;
using ProjetoModeloDDD.Domain.Contracts.Services;
using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Domain.Services
{
    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
            : base(customerRepository)

        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetSpecialsCustomers(IEnumerable<Customer> customers) => customers.Where(c => Customer.SpecialCustomer(c));
    }
}