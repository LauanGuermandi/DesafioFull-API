using System.Net.Mime;
using Financeiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeiro.Data.Mappings
{
    public class ParametroMap : IEntityTypeConfiguration<Parametro> {
        public void Configure(EntityTypeBuilder<Parametro> builder) {
            builder
              .ToTable("Parametro");

             builder
              .HasIndex(p => p.Chave)
              .IsUnique();
            builder
              .Property(p => p.Chave)
              .HasMaxLength(255)
              .IsRequired();

            builder
              .Property(p => p.Valor)
              .HasColumnType("varchar(1023)")
              .IsRequired();
        }
    }
}
