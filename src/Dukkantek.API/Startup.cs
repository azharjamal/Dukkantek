using Dukkantek.API.Configuration;
using Dukkantek.Infrastructure.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Dukkantek.Business.Authentication.Helpers;
using Dukkantek.Business.Authentication.Middleware;
using System;
using Microsoft.EntityFrameworkCore;

namespace Dukkantek.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // add services to the DI container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DukkantekDbContext>();


            services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Dukkantek.API", Version = "v1" });
            });


            services.ResolveDependencies();
            // configure strongly typed settings object
            //services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

        }

        // configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, DukkantekDbContext context)
        {

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var Dbcontext = serviceScope.ServiceProvider.GetService<DukkantekDbContext> ();
                context.Database.Migrate();
            }
            // migrate database changes on startup (includes initial db creation)
            //context.Database.Migrate();
            app.UseCors("CorsPolicy");
            // generated swagger json and swagger ui middleware
            app.UseSwagger();
            app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", ".NET Sign-up and Verification API"));

            app.UseHttpsRedirection();

            // global error handler
            app.UseMiddleware<ErrorHandlerMiddleware>();


            app.UseRouting();



            app.UseAuthentication();
            app.UseAuthorization();
            // global cors policy
            //app.UseCors(x => x
            //    .SetIsOriginAllowed(origin => true)
            //    .AllowAnyMethod()
            //    .AllowAnyHeader()
            //    .AllowCredentials());


            app.UseEndpoints(x => x.MapControllers());
        }


    }
}
