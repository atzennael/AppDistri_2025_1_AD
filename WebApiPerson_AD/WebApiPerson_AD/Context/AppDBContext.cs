using Microsoft.EntityFrameworkCore;
using WebApiPerson_AD.Models;

namespace WebApiPerson_AD.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base (options)
        {
            
        }
        public DbSet<Person> Persons{ get; set;}
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaDetalle> VentaDetalles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
