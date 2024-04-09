using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KortexCrud.Migrations
{
    /// <inheritdoc />
    public partial class Cargo_Agregado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Clientes");
        }
    }
}
