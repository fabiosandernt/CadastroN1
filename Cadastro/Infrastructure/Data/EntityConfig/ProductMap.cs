using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cadastro.Infrastructure.Data.EntityConfig
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(m => m.ClientId)
                .IsRequired();

            builder.Property(m => m.Value)
                .IsRequired();

            builder.Property(m => m.Active)
               .IsRequired();

            builder.HasOne(m => m.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(m => m.IdCategory);

            builder.HasOne(m => m.Client)
                .WithMany(x => x.Products)
                .HasForeignKey(m => m.ClientId);
        }
    }
}
