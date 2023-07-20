using Microsoft.EntityFrameworkCore;
using webservicecsharp.Model;

namespace webservicecsharp.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Server=localhost;" + "Port=5432;Database=mycompany;"+"User Id=postgres;" + "Password=root;");
    }
}
