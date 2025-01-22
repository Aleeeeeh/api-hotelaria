using api_hotelaria.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_hotelaria.Models.Data;

public class TipoCustoAdicionalContext : IEntityTypeConfiguration<TipoCustoAdicional>
{
    public void Configure(EntityTypeBuilder<TipoCustoAdicional> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Descricao)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(t => t.EstaAtivo);
    }
}
