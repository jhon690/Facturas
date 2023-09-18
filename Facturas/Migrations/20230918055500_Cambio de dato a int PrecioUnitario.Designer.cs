﻿// <auto-generated />
using System;
using Facturas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Facturas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230918055500_Cambio de dato a int PrecioUnitario")]
    partial class CambiodedatoaintPrecioUnitario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Facturas.Models.DetallesModel", b =>
                {
                    b.Property<int>("IdDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalle"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("DetallesIdProducto")
                        .HasColumnType("int");

                    b.Property<int?>("FacturasModelIdFactura")
                        .HasColumnType("int");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("PrecioUnitario")
                        .HasColumnType("int");

                    b.HasKey("IdDetalle");

                    b.HasIndex("DetallesIdProducto");

                    b.HasIndex("FacturasModelIdFactura");

                    b.ToTable("Detalles");
                });

            modelBuilder.Entity("Facturas.Models.FacturasModel", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFactura"));

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DocumentoCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("IVA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroFactura")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoDePago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalDescuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalImpuesto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdFactura");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Facturas.Models.ProductosModel", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<string>("Producto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            IdProducto = 1,
                            Producto = "Camiseta básica"
                        },
                        new
                        {
                            IdProducto = 2,
                            Producto = "Bolígrafo gel"
                        },
                        new
                        {
                            IdProducto = 3,
                            Producto = "Auriculares Bluetooth"
                        },
                        new
                        {
                            IdProducto = 4,
                            Producto = "Mochila deportiva"
                        },
                        new
                        {
                            IdProducto = 5,
                            Producto = "Pantalones vaqueros"
                        },
                        new
                        {
                            IdProducto = 6,
                            Producto = "Zapatos de tacón"
                        });
                });

            modelBuilder.Entity("Facturas.Models.DetallesModel", b =>
                {
                    b.HasOne("Facturas.Models.ProductosModel", "Detalles")
                        .WithMany("Detalles")
                        .HasForeignKey("DetallesIdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturas.Models.FacturasModel", null)
                        .WithMany("Detalles")
                        .HasForeignKey("FacturasModelIdFactura");

                    b.Navigation("Detalles");
                });

            modelBuilder.Entity("Facturas.Models.FacturasModel", b =>
                {
                    b.Navigation("Detalles");
                });

            modelBuilder.Entity("Facturas.Models.ProductosModel", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}
