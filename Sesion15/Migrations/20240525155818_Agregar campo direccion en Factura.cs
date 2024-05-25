using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sesion15.Migrations
{
    /// <inheritdoc />
    public partial class AgregarcampodireccionenFactura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Facturas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Facturas");
        }
    }
}
