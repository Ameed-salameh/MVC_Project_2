using Microsoft.EntityFrameworkCore;
using project_2.Models;

namespace project_2.Data
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;database=MVC_Project;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(

                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Furniture" },
                new Category() { Id = 3, Name = "Clothing" },
                new Category() { Id = 4, Name = "Books" },
                new Category() { Id = 5, Name = "Sports" }

                );
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Laptop", Description = "A high-performance laptop", Price = 1500, Rate = 4, Quantity = "10", CategoryId = 1},
                new Product() { Id = 2, Name = "Table", Description = "A sturdy table", Price = 500, Rate = 3, Quantity = "5", CategoryId = 2},
                new Product() { Id = 3, Name = "T-Shirt", Description = "A comfortable t-shirt", Price = 20, Rate = 4, Quantity = "10", CategoryId = 3},
                new Product() { Id = 4, Name = "Book", Description = "A book on history", Price = 25, Rate = 4, Quantity = "10", CategoryId = 4},
                new Product() { Id = 5, Name = "Basketball", Description = "A basketball", Price = 50, Rate = 4, Quantity = "10", CategoryId = 5}
                
                
                );
        }
    }
}