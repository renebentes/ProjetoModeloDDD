using ProjetoModeloDDD.Application.Contracts;
using ProjetoModeloDDD.Domain.Contracts.Services;
using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productService;

        public ProductAppService(IProductService productService)
            : base(productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> GetByName(string name) => _productService.GetByName(name);
    }
}