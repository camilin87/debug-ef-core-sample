using System;
using System.IO;
using System.Reflection;
using System.Xml;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace DebugEFCoreSample
{
  class Program
  {
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    
    static void Main(string[] args)
    {
      ConfigureLog4Net();

      Logger.Info("Started");
      Logger.Info("Finished");
    }

    private static void ConfigureLog4Net()
    {
      var log4NetConfig = new XmlDocument();
      log4NetConfig.Load(File.OpenRead("log4net.config"));
      var repo = LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(Hierarchy));
      XmlConfigurator.Configure(repo, log4NetConfig["log4net"]);
    }
  }
}