using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KortexCrud.Migrations
{
    /// <inheritdoc />
    public partial class precioadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Precio",
                table: "Producto",
                type: "INTEGER",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Precio",
                table: "Producto",
                type: "TEXT",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
