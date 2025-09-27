using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GestionAlmacenApp.Models;// Referencia a modelos (crearemos después)
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace GestionAlmacenApp.Data
{

    //#region Edit
    //#endregion
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // DbSets para entidades iniciales
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        // Agregaremos más en partes futuras (Ventas, Clientes, etc.)

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); // Configuración de Identity

            // Configuraciones iniciales (ej. índices)
            builder.Entity<Producto>(entity =>
            {
                entity.HasIndex(e => e.CodigoBarra).IsUnique(); // Código de barras único
                entity.Property(e => e.Precio).HasColumnType("decimal(18,2)"); // Precio con 2 decimales
            });

            // Más configuraciones en partes futuras
        }
    }
}
