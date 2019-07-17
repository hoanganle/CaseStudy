using Microsoft.EntityFrameworkCore;
namespace CaseStudy.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
    }
}
