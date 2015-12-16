using System;

namespace Jobs
{
  public sealed class CurrentDateTimeJob : IJob
  {
    private readonly IClock _clock;

    public CurrentDateTimeJob(IClock clock)
    {
      _clock = clock;
    }

    public void Execute()
    {
      Console.WriteLine("CurrentDateTimeJob:" + _clock.Now);
    }
  }
}
