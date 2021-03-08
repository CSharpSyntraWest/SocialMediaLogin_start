using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityByExamples.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//https://console.cloud.google.com/apis/credentials/oauthclient/648171943614-671n1c6j20ktru584s97rps3m2i7iuqd.apps.googleusercontent.com?folder=&organizationId=&project=pittig

namespace IdentityByExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().MigrateDatabase().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
