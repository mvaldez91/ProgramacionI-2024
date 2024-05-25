using Microsoft.EntityFrameworkCore;

namespace Sesion15{
    public class AppDbContext : DbContext {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=LAPTOP-7UBL09TP\\SQLSRV;Integrated Security=true;Initial Catalog=Sesion15;TrustServerCertificate=true;Trusted_Connection=true");
        }

        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    } 
}