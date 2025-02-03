using api_hotelaria.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_hotelaria.Models.Data;

public class TipoQuartoContext : IEntityTypeConfiguration<TipoQuarto>
{
    public void Configure(EntityTypeBuilder<TipoQuarto> builder)
    {
        builder.HasKey(tq => tq.Id);

        builder.Property(tq => tq.Descricao).IsRequired();

        builder.Property(tq => tq.EstaAtivo);
    }
}
