using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_hotelaria.Migrations
{
    /// <inheritdoc />
    public partial class adicionandotipoquartonatabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipoQuarto",
                table: "Quartos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoQuarto",
                table: "Quartos");
        }
    }
}
