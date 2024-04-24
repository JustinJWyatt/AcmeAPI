using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Acme.API.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public string DbPath { get; }

        private readonly string ConnectionString;

        public ApplicationDbContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(ConnectionString);
    }

    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        [Key]
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        [Key]
        public int Id { get; set; }
    }
}
