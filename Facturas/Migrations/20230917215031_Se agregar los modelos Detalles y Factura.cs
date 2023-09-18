using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Facturas.Migrations
{
    /// <inheritdoc />
    public partial class SeagregarlosmodelosDetallesyFactura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetallesIdProducto",
                table: "Detalles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FacturasModelIdFactura",
                table: "Detalles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroFactura = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoDePago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentoCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IVA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalImpuesto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.IdFactura);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Producto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_DetallesIdProducto",
                table: "Detalles",
                column: "DetallesIdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_FacturasModelIdFactura",
                table: "Detalles",
                column: "FacturasModelIdFactura");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Facturas_FacturasModelIdFactura",
                table: "Detalles",
                column: "FacturasModelIdFactura",
                principalTable: "Facturas",
                principalColumn: "IdFactura");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Productos_DetallesIdProducto",
                table: "Detalles",
                column: "DetallesIdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Facturas_FacturasModelIdFactura",
                table: "Detalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Productos_DetallesIdProducto",
                table: "Detalles");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Detalles_DetallesIdProducto",
                table: "Detalles");

            migrationBuilder.DropIndex(
                name: "IX_Detalles_FacturasModelIdFactura",
                table: "Detalles");

            migrationBuilder.DropColumn(
                name: "DetallesIdProducto",
                table: "Detalles");

            migrationBuilder.DropColumn(
                name: "FacturasModelIdFactura",
                table: "Detalles");
        }
    }
}
