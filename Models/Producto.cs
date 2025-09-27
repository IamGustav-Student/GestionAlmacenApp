using System.ComponentModel.DataAnnotations;
namespace GestionAlmacenApp.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "La descripción no puede exceder 200 caracteres")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El código de barras es requerido (o ingréselo manualmente)")]
        [StringLength(50)]
        public string CodigoBarra { get; set; } = string.Empty; // Para escaneo

        [Required(ErrorMessage = "El precio es requerido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock inicial es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        public int Stock { get; set; }

        public int StockMinimo { get; set; } = 5; // Umbral para notificaciones (configurable)

        // FK a Proveedor (agregaremos relación después)
        public int? ProveedorId { get; set; }
        public Proveedor? Proveedor { get; set; }

        // Timestamps
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public bool StockBajo { get; set; } // Flag para notificaciones (lógica en controller)

    }
}
