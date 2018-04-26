using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;
using Microsoft.EntityFrameworkCore;

namespace DebugEFCoreSample
{
  class Program
  {
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private static readonly Random generator = new Random();

    static void Main(string[] args)
    {
      ConfigureLog4Net();

      Logger.Info("Started");

      using (var context = new MyDbContextFactory().CreateDbContext())
      {
        context.Database.Migrate();

        Logger.Info($"Employees Count Before: {context.Employees.Count()}");

        context.Employees.Add(CreateEmployee());
        context.SaveChanges();

        Logger.Info($"Employees Count After: {context.Employees.Count()}");
      }

      Logger.Info("Finished");
    }

    private static Employee CreateEmployee() => new Employee
    {
      Age = generator.Next(20, 55),
      FirstName = $"Fred{generator.Next(1000, 10000)}",
      LastName = $"Doe{generator.Next(1000, 10000)}",
      Title = $"Software Engineer {generator.Next(1, 3)}"
    };

    private static void ConfigureLog4Net()
    {
      var log4NetConfig = new XmlDocument();
      log4NetConfig.Load(File.OpenRead("log4net.config"));
      var repo = LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(Hierarchy));
      XmlConfigurator.Configure(repo, log4NetConfig["log4net"]);
    }
  }
}