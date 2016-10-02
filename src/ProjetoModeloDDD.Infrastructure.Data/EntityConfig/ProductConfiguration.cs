using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infrastructure.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Price)
                .IsRequired();

            HasRequired(p => p.Customer)
                .WithMany()
                .HasForeignKey(p => p.CustomerId);
        }
    }
}