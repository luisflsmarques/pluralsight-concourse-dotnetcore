using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace pluralsight_concourse_dotnetcore
{
    public class Program
    {
        private static int deleteMe=0;

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            deleteMe=1;
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
