using AspDotNetDemoCore;
using AspDotNetDemoData;
using Microsoft.AspNetCore.Builder;

namespace AspDotNetDemo
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
            services.AddSingleton<IDataHelper<User>, UserEntity>();
            services.AddRazorPages();
            services.AddMvc(op=>op.EnableEndpointRouting=false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                // middleware
                app.UseDeveloperExceptionPage();
            }
            else    
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                
                // middleware
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseMvcWithDefaultRoute();
            app.UseEndpoints(Endpoint =>
            {
                Endpoint.MapRazorPages();
            });
        }
    }
}
