using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Models;

namespace ProductCatalogApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        //Tabla de productos 
        public DbSet<Product> Product { get; set; }

    }
}
