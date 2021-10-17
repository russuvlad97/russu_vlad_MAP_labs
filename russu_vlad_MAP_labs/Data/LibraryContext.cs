using Microsoft.EntityFrameworkCore;
using russu_vlad_MAP_labs.Models;

namespace russu_vlad_MAP_labs.Data
{
    public class LibraryContext:DbContext
    {
        /*public LibraryContext()
        {
        }*/

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Book>().ToTable("Book");
        }
    }
}
