using api_hotelaria.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_hotelaria.Models.Data;

public class QuartoContext : IEntityTypeConfiguration<Quarto>
{
    public void Configure(EntityTypeBuilder<Quarto> builder)
    {
        builder.HasKey(q => q.Id);

        builder.Property(q => q.Descricao).IsRequired();

        builder.Property(q => q.ValorDiaria).IsRequired();

        builder.Property(q => q.NumeroQuarto).IsRequired();

        builder.Property(q => q.EstaAtivo);
    }
}
