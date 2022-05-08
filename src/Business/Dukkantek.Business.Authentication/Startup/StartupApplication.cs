
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Dukkantek.Infrastructure;

namespace Dukkantek.Business.Authentication.Startup
{
    public class StartupApplication : IStartupApplication
    {

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
        }
        public void Configure(IApplicationBuilder application, IWebHostEnvironment webHostEnvironment)
        {

        }
        public int Priority => 100;
        public bool BeforeConfigure => false;

    }
}
