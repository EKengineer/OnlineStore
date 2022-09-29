using LanguageExt;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Serilog;
using Store;
using Store_Memory;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace OnlainStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            //services.AddSession(options => 
            //{
            //    //Время жизни сессии
            //    options.IdleTimeout = TimeSpan.FromMinutes(20);
            //    //Доступ к кукам только у сервера(защита от атак)
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.IsEssential = true;
            //});
            services.AddSingleton<IOrderRepositoty, OrderRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<ICartRepositoty, CartRepository>();
            services.AddSingleton<IRoleRepositoty, RoleRepository>();
            services.AddSingleton<IUsersRepository, UsersRepository>();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportadCulture = new[]
                {
                    new CultureInfo("en-US")
                };
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en-US");
                options.SupportedCultures = supportadCulture;
                options.SupportedUICultures = supportadCulture;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            var localizationOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>().Value;
            app.UseRequestLocalization(localizationOptions);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Area",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
