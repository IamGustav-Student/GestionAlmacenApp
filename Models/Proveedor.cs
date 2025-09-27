using System.ComponentModel.DataAnnotations;

namespace GestionAlmacenApp.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "La categoría es requerida")]
        [StringLength(50)]
        public string Categoria { get; set; } = string.Empty; // Ej. "Electrónicos", "Alimentos"

        [Phone(ErrorMessage = "Número de teléfono inválido")]
        public string? Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
