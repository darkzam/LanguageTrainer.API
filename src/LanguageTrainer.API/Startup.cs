using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LanguageTrainer.API.DBModels;
using LanguageTrainer.API.Repository;
using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services;
using LanguageTrainer.API.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace LanguageTrainer.API
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
            services.AddDbContext<LanguageTrainerContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("SqlConnectionString"));
                    options.EnableSensitiveDataLogging();
                });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IMistakeService, MistakeService>();
            services.AddScoped<ISourceService, SourceService>();
            services.AddScoped<IMistakesSourcesService, MistakesSourcesService>();
            services.AddScoped<ISourceTypeService, SourceTypeService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo() { Title = "Language Trainer API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/languageTrainer/swagger/v1/swagger.json", "Language Trainer API v1");
            });

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }
    }
}
