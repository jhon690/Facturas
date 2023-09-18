using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Facturas.Migrations
{
    /// <inheritdoc />
    public partial class CambiodedatoaintPrecioUnitario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PrecioUnitario",
                table: "Detalles",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "Detalles",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
