using api_hotelaria.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_hotelaria.Models.Data;

public class FormaPagamentoContext : IEntityTypeConfiguration<FormaPagamento>
{
    public void Configure(EntityTypeBuilder<FormaPagamento> builder)
    {
        builder.HasKey(f => f.Id);

        builder.Property(f => f.Descricao).IsRequired()
            .HasMaxLength(50);

        builder.Property(f => f.EstaAtivo);
    }
}
