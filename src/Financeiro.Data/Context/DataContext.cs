using Financeiro.Data.Mapeamento;
using Financeiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Divida> Divida { get; set; }
    public DbSet<Parcela> Parcela { get; set; }

    public DataContext(DbContextOptions options) : base(options)
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
