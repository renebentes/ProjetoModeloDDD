using ProjetoModeloDDD.Domain.Contracts.Repositories;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infrastructure.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
    }
}