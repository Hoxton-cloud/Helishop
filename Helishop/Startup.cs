using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helishop.Folder;
using Helishop.Folder.Interfaces;
using Helishop.Folder.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Helishop.Folder.Repository;

namespace Helishop
{
    public class Startup
    {
        private IConfigurationRoot configurationRoot;

        public Startup(IWebHostEnvironment hostingEnvironment)
        {
            configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllHelicopters, MockHelicopters>();
            services.AddTransient<IHelicopterCategory, MockCategory>();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(configurationRoot.GetConnectionString("DefaultConnection")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseMvcWithDefaultRoute();
        }
    }
}
