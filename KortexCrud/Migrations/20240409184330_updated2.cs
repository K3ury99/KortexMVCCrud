using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KortexCrud.Migrations
{
    /// <inheritdoc />
    public partial class updated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Clientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Clientes",
                type: "TEXT",
                unicode: false,
                maxLength: 100,
                nullable: true);
        }
    }
}
