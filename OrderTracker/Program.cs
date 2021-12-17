using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace THE_NAME_OF_THE_PROJECT
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
      .UseKestrel()
      .UseContentRoot(Directory.GetCurrentDirectory())
      .UseIISIntegration()
      .UseStartup<Startup>()
      .Build();
    host.Run();
    }
  }
}