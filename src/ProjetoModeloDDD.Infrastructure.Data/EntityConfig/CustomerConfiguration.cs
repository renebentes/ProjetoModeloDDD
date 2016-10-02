using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infrastructure.Data.EntityConfig
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}