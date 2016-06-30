using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using SomeClassLibrary.Application;
using SomeClassLibrary.Domain;

namespace SomConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create service collection
            IServiceCollection services = new ServiceCollection();

            // add descriptors for interfaces
            services.AddTransient<IWidgetRepository, WidgetRepository>();
            services.AddTransient<IWidgetService, WidgetService>();

            // create service provider
            IServiceProvider provider = services.BuildServiceProvider();

            // resolve the IWidgetService
            IWidgetService service = provider.GetService<IWidgetService>();

            // use the resolved Widget service
            List<Widget> widgets = service.GetAllWidgets();

            // if everything resolved, the list of hard-coded widgts will come back from the WidgetService
            foreach (var widget in widgets)
            {
                Console.WriteLine("Widget Details:");
                Console.WriteLine("  Id:" + widget.Id);
                Console.WriteLine("  Name: " + widget.Name);
                Console.WriteLine("\n");
            }

            Console.Read();
        }
    }
}
