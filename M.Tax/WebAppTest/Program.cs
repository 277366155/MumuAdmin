using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Tax.Common;

namespace WebAppTest
{
    public class Program
        {
            public static void Main(string[] args)
            {
                CreateWebHostBuilder(args).Build().Run();
            }

            public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
               .UseConfiguration(BaseCore.Configuration)
                .UseStartup<Startup>();
        }
    }
