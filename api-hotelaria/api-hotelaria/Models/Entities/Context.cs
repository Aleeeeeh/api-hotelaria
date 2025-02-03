using api_hotelaria.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace api_hotelaria.Models.Entities;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Quarto> Quartos { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Hospede> Hospedes { get; set; }
    public DbSet<FormaPagamento> FormaPagamentos { get; set; }
    public DbSet<CustoAdicional> CustosAdicionais { get; set; }
    public DbSet<TipoCustoAdicional> TipoCustosAdicionais { get; set; }
    public DbSet<Pagamento> Pagamentos { get; set; }
    public DbSet<TipoQuarto> TipoQuartos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new QuartoContext());
        modelBuilder.ApplyConfiguration(new ReservaContext());
        modelBuilder.ApplyConfiguration(new HospedeContext());
        modelBuilder.ApplyConfiguration(new FormaPagamentoContext());
        modelBuilder.ApplyConfiguration(new CustoAdicionalContext());
        modelBuilder.ApplyConfiguration(new TipoCustoAdicionalContext());
        modelBuilder.ApplyConfiguration(new PagamentoContext());
        modelBuilder.ApplyConfiguration(new TipoQuartoContext());
        base.OnModelCreating(modelBuilder);
    }
}

