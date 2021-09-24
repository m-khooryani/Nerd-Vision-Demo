using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NerdVision;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NV.Start("nv-vYbgfBZZXEjtvfQJ2cQ4");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
