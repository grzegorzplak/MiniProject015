using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace MiniProject015.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("server=localhost;database=MiniProject015;uid=root;pwd=");
        }
    }
}
