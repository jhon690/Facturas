using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Facturas.Models
{
    public class CrearDetalleViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Cantidad")]
        [Range(1, double.MaxValue, ErrorMessage = "Cantidad debe ser mayor a cero.")]
        public int? Cantidad { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Precio Unitario")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio unitario debe ser mayor o igual a cero.")]
        public int? PrecioUnitario { get; set; }

        [Required(ErrorMessage = "El campo Número de Factura es obligatorio")]
        [DisplayName("Número de Factura")]
        public int? NumeroFactura { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Date)]
        [FechaActualValidacion(ErrorMessage = "La fecha no puede ser anterior al día actual.")]
        [DisplayName("Fecha")]
        public DateTime? Fecha { get; set; }



        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Tipo de Pago")]
        public string TipoDePago { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Documento de Cliente")]
        public string DocumentoCliente { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Nombre de Cliente")]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Descuento")]
        public decimal? Descuento { get; set; }


        [Key]
        public int IdProducto { get; set; }

        [Key]
        public int IdFactura { get; set; }

    }
}
