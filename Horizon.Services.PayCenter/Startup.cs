using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horizon.Payment.Alipay;
using Horizon.Services.PayCenter.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SkyApm.Diagnostics.Grpc.Server;

namespace Horizon.Services.PayCenter
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Console.WriteLine("Startup Construction method ");
            Configuration = configuration;
            
        }

        public IConfiguration Configuration { get; }
        public ServerDiagnosticInterceptor Interceptor { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Console.WriteLine("Startup configureservices.......");
            services.AddControllersWithViews();
            //IServiceProvider provider = services.BuildServiceProvider();
            //services.AddSkyAPM()

        
            //services.AddSingleton((container) =>
            //{
            //    var logger = container.GetRequiredService<ServerDiagnosticInterceptor>();
            //    return Interceptor=logger;
            //});

            ////var interceptor = provider.GetService<ServerDiagnosticInterceptor>();
            //if (Interceptor!=null)
            //{
            //    services.AddGrpc(opt =>
            //    {
            //        opt.Interceptors.Add<ServerDiagnosticInterceptor>(Interceptor);
            //    });
            //}
            //else
            //{
            //    services.AddGrpc();
            //}

            services.AddGrpc();
            

            services.AddHorizonAlipay();
            
            //UseGrpcTrack();
            
          

            services.Configure<AlipayOptions>(Configuration.GetSection("Alipay"));
        }


        public  void UseGrpcTrack()
        {
            var services = new ServiceCollection();
            var provider = services.BuildServiceProvider();
            

            var p = provider.GetRequiredService<ServerDiagnosticInterceptor>();
            if (p!=null)
            {
                Interceptor = p;
            }
            //var interceptor = provider.GetRequiredService<ServerDiagnosticInterceptor>();
            if (Interceptor!=null)
            {
               // Interceptor = interceptor;
            }

            //services.AddSingleton((container) =>
            //{
            //    var logger = container.GetRequiredService<ServerDiagnosticInterceptor>();
            //    return Interceptor=logger;
            //});

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.Map("/health", HealthMap);
            

            app.UseEndpoints(endpoints =>
            {
                

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapGrpcService<AlipayServices>();  
            });
        }

        private static void HealthMap(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("OK");
            });
        }
    }
}
