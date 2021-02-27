using Financeiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeiro.Data.Mappings
{
    public class ParcelaMap : IEntityTypeConfiguration<Parcela>
    {
        public void Configure(EntityTypeBuilder<Parcela> builder)
        {
            builder
              .ToTable("Parcela");

            builder
              .Property(p => p.Numero)
              .IsRequired();

            builder
              .Property(p => p.DataVencimento)
              .IsRequired()
              .HasColumnType("datetime");

            builder
              .Property(p => p.Valor)
              .IsRequired()
              .HasColumnType("numeric(18,2)");

            builder
              .HasOne(p => p.Divida)
              .WithMany(d => d.Parcelas)
              .HasForeignKey(p => p.DividaId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
