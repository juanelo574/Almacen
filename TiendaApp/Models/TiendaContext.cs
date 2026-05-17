using Microsoft.EntityFrameworkCore;

namespace TiendaApp.Models
{
    public class TiendaContext: DbContext
    {
        public TiendaContext(DbContextOptions<TiendaContext> options): base(options)
        {

        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
      public  DbSet<Facturas_Detalle> Facturas_Detalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
