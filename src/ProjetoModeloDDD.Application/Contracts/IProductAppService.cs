using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Contracts
{
    public interface IProductAppService : IAppServiceBase<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}