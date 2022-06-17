using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Northw›nd.Blazor.Services;
using Northw›nd.Blazor.Services.Concrete;
using Northw›nd.Blazor.Services.Abstract;
using Microsoft.AspNetCore.Components.Authorization;
using Northw›nd.Blazor.Models;
using Blazored.SessionStorage;
using Blazored.LocalStorage;
using BlazorProjectBlazor.Services.Abstract;
using BlazorProjectBlazor.Services.Concrete;
using System.Net.Http;
using System.Net.Http.Headers;
using System;
using MatBlazor;

namespace BlazorProjectBlazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            
            services.AddBlazoredSessionStorage();
            services.AddBlazoredLocalStorage();
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:21021"),
            };            
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            services.AddSingleton<HttpClient>(httpClient);
            
            services.AddScoped<IAuthService, AuthService>();            
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICargoService, CargoService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IColourService, ColourService>();                       
            services.AddScoped<IUserAddressService, UserAddressService>();


            services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
            });

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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();           
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
