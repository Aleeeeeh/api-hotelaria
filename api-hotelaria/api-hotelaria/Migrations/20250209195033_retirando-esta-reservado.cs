using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_hotelaria.Migrations
{
    /// <inheritdoc />
    public partial class retirandoestareservado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstaReservado",
                table: "Quartos");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CheckOut",
                table: "Reservas",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CheckIn",
                table: "Reservas",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Reservas",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Reservas",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<bool>(
                name: "EstaReservado",
                table: "Quartos",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
