using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }


        public DbSet<Product> Products { get; set; }
    }
}