using System;
using System.Web.Mvc;

using Hangfire;

using Jobs;

namespace HangfireDemo.Controllers
{
    public class JobController : Controller
    {
        //
        // GET: /Job/

        public ActionResult Index()
        {
            return View();
        }

      [HttpPost]
        public ActionResult CreateJob(int delayInSeconds)
      {
        if (delayInSeconds == 0)
        {
          Hangfire.BackgroundJob.Enqueue<CurrentDateTimeJob>(j => j.Execute());
        }
        else if (delayInSeconds < 0)
        {
          Hangfire.RecurringJob.AddOrUpdate<CurrentDateTimeJob>(j => j.Execute(), Cron.Minutely);
        }
        else
        {
          Hangfire.BackgroundJob.Schedule<CurrentDateTimeJob>(j => j.Execute(), TimeSpan.FromSeconds(delayInSeconds));
        }
    
        return Redirect("Index");
      }
    }
}
