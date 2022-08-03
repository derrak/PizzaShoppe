using Microsoft.EntityFrameworkCore;

namespace PizzaShoppe.Models
{
  public class PizzaShoppeContext : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<CustomerOrder> CustomerOrder { get; set; }

    public PizzaShoppeContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}