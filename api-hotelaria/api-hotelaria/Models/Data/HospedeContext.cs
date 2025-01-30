using api_hotelaria.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_hotelaria.Models.Data
{
    public class HospedeContext : IEntityTypeConfiguration<Hospede>
    {
        public void Configure(EntityTypeBuilder<Hospede> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.Nome).IsRequired();

            builder.Property(h => h.Email);

            builder.Property(h => h.Telefone).IsRequired();

            builder.Property(h => h.DataNascimento).IsRequired();

            builder.Property(h => h.Cpf).IsRequired();

            builder.Property(h => h.Rg);

            builder.Property(h => h.Endereco).IsRequired();

            builder.Property(h => h.Numero).IsRequired();

            builder.Property(h => h.Complemento);

            builder.Property(h => h.Referencia);

            builder.Property(h => h.DataCadastro);

            builder.Property(h => h.HoraCadastro);

            builder.Property(h => h.DataAtualizacao);

            builder.Property(h => h.HoraAtualizacao);

            builder.Property(h => h.EstaAtivo).HasDefaultValue(true);
        }
    }
}
