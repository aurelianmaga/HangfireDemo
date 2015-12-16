using System;

namespace Jobs
{
  public interface IClock
  {
    DateTime Now { get; }
  }
}
