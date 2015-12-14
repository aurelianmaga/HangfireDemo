using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

using Owin;

namespace HangfireDemo
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      Hangfire.SqlServerStorageExtensions.UseSqlServerStorage(Hangfire.GlobalConfiguration.Configuration, "Jobs");
      Hangfire.AppBuilderExtensions.UseHangfireDashboard(app, "/dashboard");

      AreaRegistration.RegisterAllAreas();

      WebApiConfig.Register(GlobalConfiguration.Configuration);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
    }
  }
}