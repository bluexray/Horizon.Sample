using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Horizon.Payment.Alipay.Domain;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Horizon.Services.PayCenter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .UseConsoleLifetime().Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    Console.WriteLine("Addskyapm");
                    services.AddSkyAPM();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel((context, options) =>
                    {
                        options.Limits.MinRequestBodyDataRate = null;
                    });

                    //配置grpc的协议端口
                    webBuilder.UseKestrel(ops =>
                    {
                        ops.Listen(IPAddress.Any, 5021, listenOptions =>
                        {
                            listenOptions.Protocols = HttpProtocols.Http2;
                            //listenOptions.UseHttps("<path to .pfx file>", 
                            //    "<certificate password>");
                        });
                    });
                 
                    ////配置http健康检查协议和mvc端口
                    webBuilder.UseKestrel(o=>
                    {
                        o.ListenAnyIP(5022);
                    });
                    Console.WriteLine("begin startup");
                    webBuilder.UseStartup<Startup>();
                })
                ;
                
    }
}
