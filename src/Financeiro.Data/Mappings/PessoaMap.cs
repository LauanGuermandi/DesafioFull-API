using Financeiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeiro.Data.Mappings
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder
              .ToTable("Pessoa");

            builder
              .HasKey(p => p.Id);

            builder
              .Property(p => p.Nome)
              .IsRequired()
              .HasMaxLength(255);

            builder
              .HasIndex(p => p.CPF)
              .IsUnique();
            builder
              .Property(p => p.CPF)
              .IsRequired()
              .HasMaxLength(11);

            builder
              .HasMany(p => p.Dividas)
              .WithOne(d => d.Pessoa)
              .HasForeignKey(d => d.PessoaId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
