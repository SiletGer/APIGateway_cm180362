using Microsoft.EntityFrameworkCore;

namespace ProductoAPI.Models
{
    public class ProductoContext : DbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext> options) 
            : base(options) 
        {
        }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "Laptop",
                    Categoria = "Electrónica",
                    Descripcion = "Una laptop de alto rendimiento."
                },
                new Producto
                {
                    Id = 2,
                    Nombre = "Smartphone",
                    Categoria = "Electrónica",
                    Descripcion = "Una Smartphone de nueva generacion."
                },
                new Producto
                {
                    Id = 3,
                    Nombre = "Silla de escritorio",
                    Categoria = "Muebles",
                    Descripcion = "Una silla de escritorio comoda."
                }
                );
        }
    }
}
