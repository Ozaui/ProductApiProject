using Microsoft.EntityFrameworkCore;
using ProductProject.Models.Entities;

namespace ProductProject.Repository;

public class BaseDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; Database=tc_product_db; Trusted_Connection=true");
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories {  get; set; } 
}
