using api_hotelaria.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_hotelaria.Models.Data;

public class ReservaContext : IEntityTypeConfiguration<Reserva>
{
    public void Configure(EntityTypeBuilder<Reserva> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Hospede)
            .IsRequired()
            .HasColumnType("int");

        builder.Property(r => r.Quarto)
            .IsRequired()
            .HasColumnType("int");

        builder.Property(r => r.CheckIn);

        builder.Property(r => r.CheckOut);

        builder.Property(r => r.Status)
            .IsRequired()
            .HasConversion<string>();

        builder.Property(r => r.DataCadastro);

        builder.Property(r => r.HoraCadastro);
    }
}
