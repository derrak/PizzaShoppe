using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PizzaShoppe.Models
{
  public class PizzaShoppeContextFactory : IDesignTimeDbContextFactory<PizzaShoppeContext>
  {

    PizzaShoppeContext IDesignTimeDbContextFactory<PizzaShoppeContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PizzaShoppeContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new PizzaShoppeContext(builder.Options);
    }
  }
}