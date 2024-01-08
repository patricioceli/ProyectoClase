using Microsoft.EntityFrameworkCore;
using ProyectoClase.Models.Entidades;

namespace ProyectoClase.Models
{
    public class LibreriaContext : DbContext
    {
        public LibreriaContext()
        {
        }
        public LibreriaContext(DbContextOptions<LibreriaContext> options) : base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categoria>().HasIndex(c => c.Nombre).IsUnique();
        }


    }
}
