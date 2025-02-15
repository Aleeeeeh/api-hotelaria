﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_hotelaria.Models.Entities;

#nullable disable

namespace api_hotelaria.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250204101736_adicionando-tipo-quarto-na-tabela")]
    partial class adicionandotipoquartonatabela
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_hotelaria.Models.Entities.CustoAdicional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DataCobranca")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("HoraCobranca")
                        .HasColumnType("time without time zone");

                    b.Property<int>("Reserva")
                        .HasColumnType("integer");

                    b.Property<int>("TipoCusto")
                        .HasColumnType("integer");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("CustosAdicionais");
                });

            modelBuilder.Entity("api_hotelaria.Models.Entities.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("FormaPagamentos");
                });

            modelBuilder.Entity("api_hotelaria.Models.Entities.Hospede", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("DataAtualizacao")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DataCadastro")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("EstaAtivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<TimeOnly>("HoraAtualizacao")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly>("HoraCadastro")
                        .HasColumnType("time without time zone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Referencia")
                        .HasColumnType("text");

                    b.Property<string>("Rg")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Hospedes");
                });

            modelBuilder.Entity("api_hotelaria.Models.Entities.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DataPagamento")
                        .HasColumnType("date");

                    b.Property<int>("FormaPagamento")
                        .HasColumnType("integer");

                    b.Property<TimeOnly>("HoraPagamento")
                        .HasColumnType("time without time zone");

                    b.Property<int>("Reserva")
                        .HasColumnType("integer");

                    b.Property<int>("StatusPagamento")
                        .HasColumnType("integer");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("api_hotelaria.Models.Entities.Quarto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("boolean");

                    b.Property<bool>("EstaReservado")
                        .HasColumnType("boolean");

                    b.Property<int>("NumeroQuarto")
                        .HasColumnType("integer");

                    b.Property<string>("TipoQuarto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("ValorDiaria")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("api_hotelaria.Models.Entities.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateOnly>("DataCadastro")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("HoraCadastro")
                        .HasColumnType("time without time zone");

                    b.Property<int>("Hospede")
                        .HasColumnType("int");

                    b.Property<int>("Quarto")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("api_hotelaria.Models.Entities.TipoCustoAdicional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("TipoCustosAdicionais");
                });
#pragma warning restore 612, 618
        }
    }
}
