﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WilpSocialMedia.Activity.Domain.Model;
using WilpSocialMedia.Common;
using WilpSocialMedia.Common.API.Attributes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;

namespace WilpSocialMedia.Activity
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
            services.InitBootsraper();

            services.AddDbContext<Wilpsocialmedia_ActivityContext>(options =>
                options.UseSqlServer(Configuration.GetSection("ConnectionString").Value));

            services.AddCors();

            services.AddMvcCore()
                .AddJsonFormatters(j => j.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            ).AddApiExplorer();

            string basePath = PlatformServices.Default.Application.ApplicationBasePath;
            string xmlPath = Path.Combine(basePath, "WebAPI.xml");

            services.ConfigSwagger("Activity Service", xmlPath);

            services.AddMvc(
                options => {
                    options.Filters.Add(typeof(ValidateModelStateAttribute));
                }
            ).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddAutoMapper(typeof(MappingProfile));

            //IoC for Application
            services.InitAppBootsraper();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            // FOR UI Interface API
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", $"Wilp Social Media Microservices API {Global.API.Version}");
            });
        }
    }
}
