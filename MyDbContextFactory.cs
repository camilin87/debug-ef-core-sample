using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DebugEFCoreSample
{
  public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
  {
    public MyDbContext CreateDbContext()
    {
      return CreateDbContext(null);
    }

    public MyDbContext CreateDbContext(string[] args)
    {
      var optionsBuilder = new DbContextOptionsBuilder();
      optionsBuilder.UseSqlite("Data Source=employees.db");
      return new MyDbContext(optionsBuilder.Options);
    }
  }
}