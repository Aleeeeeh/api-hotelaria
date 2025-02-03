using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_hotelaria.Migrations
{
    /// <inheritdoc />
    public partial class adicionadoestareservadotabelaquarto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstaReservado",
                table: "Quartos",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstaReservado",
                table: "Quartos");
        }
    }
}
