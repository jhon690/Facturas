using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using System.Diagnostics;
using System.Drawing;

namespace Facturas.Models
{
    public class FacturasModel
    {
        [Key]
        public int IdFactura { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
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
        public string? NombreCliente { get; set; }

        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Descuento")]
        public decimal? Descuento { get; set; }

        public decimal IVA { get; set; }

        public decimal TotalDescuento { get; set; }

        public decimal TotalImpuesto { get; set; }

        public decimal Total { get; set; }

        public List<DetallesModel> Detalles { get; set;}
    }

    public class FechaActualValidacionAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime fecha)
            {

                DateTime fechaActual = DateTime.Now.Date;

                if (fecha < fechaActual)
                {
                    return false; 
                }
            }

            return true; 
        }
    }
}
