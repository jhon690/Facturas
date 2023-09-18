using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturas.Models
{
    public class DetallesModel
    {
        [Key]
        public int IdDetalle { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Identificador de Factura")]
        public int IdFactura { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Identificador de Producto")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Cantidad")]
        [Range(1, double.MaxValue, ErrorMessage = "Cantidad debe ser mayor a cero.")]
        public int? Cantidad { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Precio Unitario")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio unitario debe ser mayor o igual a cero.")]
        public int? PrecioUnitario { get; set; }

        public ProductosModel Detalles { get; set; }
    }
}
