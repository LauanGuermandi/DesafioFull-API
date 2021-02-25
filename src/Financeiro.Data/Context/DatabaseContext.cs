using Financeiro.Data.Mapeamento;
using Financeiro.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Context
{
  public class DatabaseContext : DbContext
  {
    public DbSet<Pessoa> Pessoas { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.ApplyConfiguration(new PessoaMap());
      modelBuilder.ApplyConfiguration(new DividaMap());
      modelBuilder.ApplyConfiguration(new ParcelaMap());
    }
  }
}
