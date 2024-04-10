using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KortexCrud.Migrations
{
    /// <inheritdoc />
    public partial class precios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Precio",
                table: "Producto",
                type: "TEXT",
                unicode: false,
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Producto");
        }
    }
}
