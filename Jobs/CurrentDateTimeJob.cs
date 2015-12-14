using System;

namespace Jobs
{
  public sealed class CurrentDateTimeJob : IJob
  {
    public void Execute()
    {
      Console.WriteLine("CurrentDateTimeJob:" + DateTime.Now);
    }
  }
}
