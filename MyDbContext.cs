using Microsoft.EntityFrameworkCore;

namespace DebugEFCoreSample
{
  public class MyDbContext : DbContext
  {
    public DbSet<Employee> Employees { get; set; }
    
    public MyDbContext(DbContextOptions options) : base(options) { }
  }
}