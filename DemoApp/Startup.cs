using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DemoApp
{
    public class Startup
    {
        // Use this method to add framework services (MVC, EF, Identity, Logging) and application services 
        public void ConfigureServices(IServiceCollection services)
        {
            // add GZipCompression service
            services.AddResponseCompression();
            
            // services.AddDirectoryBrowser();

            services.AddTransient<IMesssage, RuntimeMessage>();
        }

        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            // Response Compression Middleware
            // Verify Response Headers. You should see Content - Encoding: gzip
            app.UseResponseCompression();

            // WelcomePage middleware added to pipeline for Production envronnment.
            if (env.IsProduction())
            {
                // app.UseWelcomePage();
                app.UseWelcomePage("/Home");
            }

            // static file middleware
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseDirectoryBrowser();
            // or enable all static file middleware in one line
            // app.UseFileServer(enableDirectoryBrowsing: true);


            // inline demo middleware 
            app.Use(async (context, next) =>
            {
                // context.Response.ContentType = "text/plain";  // for MS Edge
                await context.Response.WriteAsync("Hello from inline demo middleware...");
                // invoke the next middleware
                await next.Invoke();
            });

            // standalone DemoMiddleWare;
            app.UseDemoMiddleware();

            // terminal middleware
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Welcome to ASP.NET Core!..." + "\n");
                await context.Response.WriteAsync(env.ContentRootPath + "\r\n");
                await context.Response.WriteAsync(env.WebRootPath);
            });

        }
    }
}
