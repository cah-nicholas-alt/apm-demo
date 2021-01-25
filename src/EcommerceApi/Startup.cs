using EcommerceApi.Data;
using Elastic.Apm;
using Elastic.Apm.NetCoreAll;
using Elastic.Apm.StackExchange.Redis;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StackExchange.Redis;

namespace EcommerceApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<EcommerceDbContext>(o => o.UseSqlServer("Data Source=localhost,1433;User ID=sa;Password=secure_Password_~;Database=Ecommerce"));
            services.AddHttpClient();
            
            var redisConnection = ConnectionMultiplexer.Connect("localhost:6379");
            
            services.AddSingleton<IConnectionMultiplexer>(redisConnection);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, IConnectionMultiplexer redisConnection)
        {
            app.UseAllElasticApm(configuration);
            redisConnection.UseElasticApm();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}