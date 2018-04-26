using DebugEFCore;
using Microsoft.EntityFrameworkCore;

namespace DebugEFCoreSample
{
  public class MyDbContext : DbContext
  {
    public static readonly bool DEBUG_ENABLED = false; 
    
    public DbSet<Employee> Employees { get; set; }
    
    public MyDbContext(DbContextOptions options) : base(options) { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.EnableLogging(DEBUG_ENABLED);
    }
  }
}