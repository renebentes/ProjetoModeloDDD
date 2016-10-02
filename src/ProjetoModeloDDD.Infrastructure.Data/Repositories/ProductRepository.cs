using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infrastructure.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByName(string name)
        {
            return context.Products.Where(p => p.Name == name);
        }
    }
}