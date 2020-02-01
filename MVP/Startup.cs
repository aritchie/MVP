using System;
using Microsoft.Extensions.DependencyInjection;
using MVP.Services;
using Shiny;
using Shiny.Jobs;


namespace MVP
{
    public class Startup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.UseNotifications();
            services.RegisterJob(new JobInfo(typeof(DataSyncJob))
            {
                BatteryNotLow = true,
                RequiredInternetAccess = InternetAccess.Any
            });
        }
    }
}
