using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cubo.Api.Middleware;
using Cubo.Core.Domain;
using Cubo.Core.EF;
using Cubo.Core.Mappers;
using Cubo.Core.Repositories;
using Cubo.Core.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Cubo.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.Configure<SqlSettings>(Configuration.GetSection("sql"));
            // services.AddSingleton<IBucketRepository,InMemoryBucketRepository>();
            services.AddScoped<IBucketRepository,SqlBucketRepository>();
            services.AddScoped<IBucketService,BucketService>();
            services.AddScoped<IItemService,ItemService>();
            services.AddScoped<IDataInitializer,DataInitializer>();
            services.AddSingleton<IMapper>(_ => AutoMapperConfig.GetMapper());
            services.AddEntityFrameworkSqlServer()
                    .AddEntityFrameworkInMemoryDatabase()
                    .AddDbContext<CuboContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMiddleware<ErrorHandlerMiddleware>();
            app.UseStaticFiles();
            app.UseMvc();

            var dataInitializer = app.ApplicationServices.GetService<IDataInitializer>();
            if(dataInitializer != null)
            {
                dataInitializer.SeedAsync();
            }
        }
    }
}
