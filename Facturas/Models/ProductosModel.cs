using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Facturas.Models
{
    public class ProductosModel
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        [DisplayName("Producto")]
        public string Producto { get; set; }

        public List<DetallesModel> Detalles { get; set; }
    }
}
