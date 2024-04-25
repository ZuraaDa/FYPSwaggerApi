using Microsoft.EntityFrameworkCore;
using FYPSwaggerApi.Models;

namespace FYPSwaggerApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions) { }
        public DbSet<item_model> Items { get; set; }
        public DbSet<order_model> Orders { get; set; }
        public DbSet<employee_model> Employees { get; set; }
        public DbSet<user_model> Users { get; set; }
        public DbSet<date_model> dateTime { get; set; }
        public DbSet<note_model> Notes { get; set; } 
    }
}


