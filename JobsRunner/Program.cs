using System;
using Hangfire;

namespace JobsRunner
{
  public class Program
  {
    public static void Main(string[] args)
    {
      GlobalConfiguration.Configuration.UseSqlServerStorage("Jobs");

      using (new BackgroundJobServer())
      {
        Console.WriteLine("Hangfire Server started. Press any key to exit...");
        Console.ReadKey();
      }
    }
  }
}
