using System.ComponentModel.DataAnnotations;

namespace DebugEFCoreSample
{
  public class Employee
  {
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Title { get; set; }
  }
}