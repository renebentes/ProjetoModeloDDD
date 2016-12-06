using ProjetoModeloDDD.Domain.Contracts.Repositories;
using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infrastructure.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByName(string name) => _context.Products.Where(p => p.Name == name);
    }
}