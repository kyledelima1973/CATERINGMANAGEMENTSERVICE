using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using CATERINGMANAGEMENTSERVICE.Models;

namespace CATERINGMANAGEMENTSERVICE.data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add any additional model configurations here
            modelBuilder.Entity<Menu>().HasNoKey();
        }

        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<Menu> Menus { get; set; }
        DbSet<PackageMenu> PackageMenus { get; set; }
        
        // Add your DbSet(s) here later
        // public DbSet<PackageMenu> Packages { get; set; }
    }
}
