using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KortexCrud.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Apellido = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Cedula = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Clientes__3DD0A8CBFDDF51F7", x => x.Id_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id_Producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Marca = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Modelo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Producto__2085A9CFB4F63BAA", x => x.Id_Producto);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    Id_Vendedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Apellido = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Vendedor__BD6EA72BC4FEF08B", x => x.Id_Vendedor);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
