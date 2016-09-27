using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infrastructure.Data.Mappings
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
        }
    }
}