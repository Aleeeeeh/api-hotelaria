using api_hotelaria.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_hotelaria.Models.Data;

public class CustoAdicionalContext : IEntityTypeConfiguration<CustoAdicional>
{
    public void Configure(EntityTypeBuilder<CustoAdicional> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Reserva).IsRequired();

        builder.Property(c => c.TipoCusto).IsRequired();

        builder.Property(c => c.Valor).IsRequired();

        builder.Property(c => c.DataCobranca);

        builder.Property(c => c.HoraCobranca);
    }
}
