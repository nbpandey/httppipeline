using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace DemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseUrls("http://*:5000")
                .UseKestrel()
                .UseWebRoot(Directory.GetCurrentDirectory() + "/www")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
