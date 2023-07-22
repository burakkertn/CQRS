using Microsoft.EntityFrameworkCore;

namespace Casgem_CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BURAK\\SQLEXPRESS;database= CQRS;integrated security = true");

        }
        public DbSet<Product> Products { get; set; }
    }
}
