using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace CaseStudy.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Tray> Trays { get; set; }
        public virtual DbSet<TrayItem> TrayItems { get; set; }
    }
}


