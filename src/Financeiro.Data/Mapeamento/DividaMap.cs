using Financeiro.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeiro.Data.Mapeamento
{
    public class DividaMap : IEntityTypeConfiguration<Divida>
    {
        public void Configure(EntityTypeBuilder<Divida> builder)
        {
            builder
              .ToTable("Divida");

            builder
              .HasKey(d => d.Id);

            builder
              .Property(d => d.ValorOriginal)
              .IsRequired()
              .HasColumnType("numeric(18,2)");

            builder
              .Property(d => d.PessoaId)
              .IsRequired();

            builder
              .HasOne(d => d.Pessoa)
              .WithMany(p => p.Dividas);
        }
    }
}
