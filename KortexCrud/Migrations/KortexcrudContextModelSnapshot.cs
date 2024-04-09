﻿// <auto-generated />
using KortexCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore.Metadata;
>>>>>>> master
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KortexCrud.Migrations
{
    [DbContext(typeof(KortexcrudContext))]
    partial class KortexcrudContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
<<<<<<< HEAD
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");
=======
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
>>>>>>> master

            modelBuilder.Entity("KortexCrud.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
<<<<<<< HEAD
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id_Cliente");

                    b.Property<string>("Apellido")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("int")
                        .HasColumnName("Id_Cliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Apellido")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");
>>>>>>> master

                    b.Property<string>("Cedula")
                        .HasMaxLength(100)
                        .IsUnicode(false)
<<<<<<< HEAD
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("varchar(100)");
>>>>>>> master

                    b.Property<string>("Direccion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
<<<<<<< HEAD
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("varchar(100)");
>>>>>>> master

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
<<<<<<< HEAD
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("varchar(100)");
>>>>>>> master

                    b.Property<string>("Telefono")
                        .HasMaxLength(100)
                        .IsUnicode(false)
<<<<<<< HEAD
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("varchar(100)");
>>>>>>> master

                    b.HasKey("IdCliente")
                        .HasName("PK__Clientes__3DD0A8CBFDDF51F7");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("KortexCrud.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
<<<<<<< HEAD
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id_Producto");

                    b.Property<string>("Marca")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("int")
                        .HasColumnName("Id_Producto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<string>("Marca")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");
>>>>>>> master

                    b.Property<string>("Modelo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
<<<<<<< HEAD
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("varchar(100)");
>>>>>>> master

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
<<<<<<< HEAD
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("varchar(100)");
>>>>>>> master

                    b.HasKey("IdProducto")
                        .HasName("PK__Producto__2085A9CFB4F63BAA");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("KortexCrud.Models.Vendedor", b =>
                {
                    b.Property<int>("IdVendedor")
                        .ValueGeneratedOnAdd()
<<<<<<< HEAD
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id_Vendedor");

                    b.Property<string>("Apellido")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("int")
                        .HasColumnName("Id_Vendedor");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVendedor"));

                    b.Property<string>("Apellido")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");
>>>>>>> master

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
<<<<<<< HEAD
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("varchar(100)");
>>>>>>> master

                    b.Property<string>("Telefono")
                        .HasMaxLength(100)
                        .IsUnicode(false)
<<<<<<< HEAD
                        .HasColumnType("TEXT");
=======
                        .HasColumnType("varchar(100)");
>>>>>>> master

                    b.HasKey("IdVendedor")
                        .HasName("PK__Vendedor__BD6EA72BC4FEF08B");

                    b.ToTable("Vendedor", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}