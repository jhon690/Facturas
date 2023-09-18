using Facturas.Models;
using Microsoft.EntityFrameworkCore;

namespace Facturas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }

        // Aquí listaremos los modelos
        public DbSet<DetallesModel> Detalles { get; set; }

        public DbSet<FacturasModel> Facturas { get; set;}

        public DbSet<ProductosModel> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductosModel>().HasData(
                new ProductosModel { IdProducto = 1, Producto = "Camiseta básica" },
                new ProductosModel { IdProducto = 2, Producto = "Bolígrafo gel" },
                new ProductosModel { IdProducto = 3, Producto = "Auriculares Bluetooth" },
                new ProductosModel { IdProducto = 4, Producto = "Mochila deportiva" },
                new ProductosModel { IdProducto = 5, Producto = "Pantalones vaqueros" },
                new ProductosModel { IdProducto = 6, Producto = "Zapatos de tacón" }
            );
        }


    }
}
