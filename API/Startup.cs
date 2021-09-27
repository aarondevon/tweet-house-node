using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TwitterShowcaseLibrary.Services;
using TwitterShowcaseLibrary.Twitter;

namespace API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllers();

            services.AddSpaStaticFiles(config =>
            {
                config.RootPath = "client/build";
            });
            services.AddHttpClient();
            services.AddScoped<IUserTweetService, UserTweetService>();
            services.AddScoped<IGetUserTweet, GetUserTweet>();
            services.AddScoped<IKeywordTweetService, KeywordTweetService>();
            services.AddScoped<IGetTweetBasedOnKeyword, GetTweetBasedOnKeyword>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGetUserData, GetUserData>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "client";
                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer("start");
                }
            });
        }
    }
}
