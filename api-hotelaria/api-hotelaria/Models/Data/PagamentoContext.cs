using api_hotelaria.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_hotelaria.Models.Data;

public class PagamentoContext : IEntityTypeConfiguration<Pagamento>
{
    public void Configure(EntityTypeBuilder<Pagamento> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Reserva).IsRequired();

        builder.Property(p => p.ValorTotal).IsRequired();

        builder.Property(p => p.FormaPagamento).IsRequired();

        builder.Property(p => p.StatusPagamento).IsRequired();

        builder.Property(p => p.DataPagamento).IsRequired();

        builder.Property(p => p.HoraPagamento).IsRequired();
    }
}
