using System;

namespace Jobs
{
  public sealed class Clock : IClock
  {
    public DateTime Now
    {
      get
      {
        return DateTime.Now;
      }
    }
  }
}
