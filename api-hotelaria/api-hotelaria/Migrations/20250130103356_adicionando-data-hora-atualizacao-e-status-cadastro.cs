using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_hotelaria.Migrations
{
    /// <inheritdoc />
    public partial class adicionandodatahoraatualizacaoestatuscadastro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DataAtualizacao",
                table: "Hospedes",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<bool>(
                name: "EstaAtivo",
                table: "Hospedes",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "HoraAtualizacao",
                table: "Hospedes",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Hospedes");

            migrationBuilder.DropColumn(
                name: "EstaAtivo",
                table: "Hospedes");

            migrationBuilder.DropColumn(
                name: "HoraAtualizacao",
                table: "Hospedes");
        }
    }
}
