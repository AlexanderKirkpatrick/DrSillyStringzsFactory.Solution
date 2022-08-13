using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Silly_Factory.Models
{
  public class Silly_FactoryContextFactory : IDesignTimeDbContextFactory<Silly_FactoryContext>
  {

    Silly_FactoryContext IDesignTimeDbContextFactory<Silly_FactoryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<Silly_FactoryContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new Silly_FactoryContext(builder.Options);
    }
  }
}