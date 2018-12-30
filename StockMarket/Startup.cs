using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockMarket.Adapter;
using StockMarket.Adapter.Interface;
using StockMarket.Adapter.Interface.Utilities;
using StockMarket.Adapter.Utilities;
using StockMarket.BAL.Generate_TimeSeries;
using StockMarket.BAL.ExtractText;
using StockMarket.BAL.Generate_TimeSeries.Interfaces;
using StockMarket.BAL.Generate_TimeSeries.Interfaces.Utilities;
using StockMarket.BAL.Generate_TimeSeries.Utilities;
using StockMarket.Model.Configuration;
using Swashbuckle.AspNetCore.Swagger;
using StockMarket.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StockMarket.Repository.Concreate;
using StockMarket.Repository.Interface;

namespace StockMarket
{
    public class Startup
    {
        private readonly AppConfiguration AppConfiguration;
        public Startup(
            IConfiguration configuration
            , IOptions<AppConfiguration> _AppConfiguration
            )
        {
            AppConfiguration = _AppConfiguration.Value;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //var connection = AppConfiguration.ConnectionString;
            var connection = "";
            services.AddDbContext<SalDbContext>
                (options => options.UseSqlServer(connection));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddHttpClient();

            services.Configure<AppConfiguration>(Configuration.GetSection("AppConfiguration"));

            services.AddScoped<ISalDbContext, SalDbContext>();
            
            services.AddScoped<IQuandlHistoricalStockAdapter, QuandlHistoricalStockAdapter>();
            services.AddScoped<IQuamdlHisoricalStockRepository, QuandlHisoricalStockRepository>();

            services.AddScoped<IRDotNetConvertor, RDotNetConvertor>();
            services.AddScoped<IRdotNetAdapter, RdotNetAdapter>();
            services.AddScoped<IRdotNetRepositories, RdotNetRepositories>();
            services.AddScoped<IGenerateTimeseriesBAL, GenerateTimeseriesBAL>();
            services.AddScoped<ITwitterAdapter, TwitterAdapter>();
            services.AddScoped<ITwitterRepository, TwitterRepository>();
            services.AddScoped<ITwitterBal, TwitterBal>();
            

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            services.AddSwaggerGen(c =>
             {
                 c.SwaggerDoc("v1", new Info
                 {
                     Version = "v1",
                     Title = "ToDo API",
                     Description = "A simple example ASP.NET Core Web API",
                     TermsOfService = "None",
                     Contact = new Contact
                     {
                         Name = "Shayne Boyer",
                         Email = string.Empty,
                         Url = "https://twitter.com/spboyer"
                     },
                     License = new License
                     {
                         Name = "Use under LICX",
                         Url = "https://example.com/license"
                     }
                 });
             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
