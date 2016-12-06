using ProjetoModeloDDD.Application.Contracts;
using ProjetoModeloDDD.Domain.Contracts.Services;
using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application
{
    public class CustomerAppService : AppServiceBase<Customer>, ICustomerAppService
    {
        private readonly ICustomerService _customerService;

        public CustomerAppService(ICustomerService customerService)
        : base(customerService)
        {
            _customerService = customerService;
        }

        public IEnumerable<Customer> GetSpecialsCustomers() => _customerService.GetSpecialsCustomers(_customerService.GetAll());
    }
}