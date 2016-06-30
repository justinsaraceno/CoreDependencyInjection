using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SomeClassLibrary.Domain;
using SomeClassLibrary.Application;

namespace SomeWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // add descriptors for interfaces
            services.AddScoped<IWidgetRepository, WidgetRepository>();
            services.AddScoped<IWidgetService, WidgetService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IWidgetService widgetService)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                // use the resolved Widget service
                List<Widget> widgets = widgetService.GetAllWidgets();

                // if everything resolved, print out the Name property value of the first widget
                await context.Response.WriteAsync(widgets.FirstOrDefault().Name);
            });
        }
    }
}
