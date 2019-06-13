using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Data;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Controllers;
using SocialNetwork.Hubs;

namespace SocialNetwork
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            DependenciesResolver.RegisterOn(services);

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder =>
                builder.AllowAnyHeader()
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowCredentials());
            });
            
            
           

            services.AddDbContext<SocialNetworkContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("SocialNetwork.Infraestructure"))
                );
                
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/SignalR/ChatMessages");
            });
            app.UseMvc();
            
        }
    }
}
