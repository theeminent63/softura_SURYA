using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 
namespace NewEF.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext()
        {

        }
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RRCVLCD;Initial Catalog=Trial;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
