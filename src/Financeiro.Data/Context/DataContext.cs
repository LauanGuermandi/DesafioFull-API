using Financeiro.Data.Mappings;
using Financeiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Divida> Dividas { get; set; }
    public DbSet<Parcela> Parcelas { get; set; }
    public DbSet<Parametro> Parametros { get; set; }

    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new PessoaMap());
        modelBuilder.ApplyConfiguration(new DividaMap());
        modelBuilder.ApplyConfiguration(new ParcelaMap());
        modelBuilder.ApplyConfiguration(new ParametroMap());
    }
}
