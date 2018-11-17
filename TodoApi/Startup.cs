using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using TodoApi.Models;

namespace TodoApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
          //  services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddDbContext<TodoContext>(option => option.UseNpgsql(ConfigrationManage.Configuration.GetConnectionString("PostgreSql")));

           
//            services.AddDbContext<TodoContext>(opt => 
  //              opt.UseInMemoryDatabase("TodoList"));
 //           services.AddMvc()
   //                 .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }

    public class ConfigrationManage
    {
        public readonly static IConfiguration Configuration;
        static ConfigrationManage()
        {
            Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true).Build();
        }
    }
}