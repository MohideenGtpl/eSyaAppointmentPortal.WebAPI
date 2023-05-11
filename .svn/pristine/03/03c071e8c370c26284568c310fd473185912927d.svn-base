using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using eSyaAppointmentPortal.DL.Entities;
using eSyaAppointmentPortal.DL.Repository;
using eSyaAppointmentPortal.IF;
using eSyaAppointmentPortal.WebAPI.Extention;
using eSyaAppointmentPortal.WebAPI.Utility;
using Microsoft.EntityFrameworkCore;
using eSyaAppointmentPortal.Filters;

namespace eSyaAppointmentPortal.WebAPI
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
            //Registering Api key filters
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ApikeyAuthAttribute));
                // An instance
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //for cross origin support
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });

            //uncomment if you want to Remove API KEY Authentication

            //services.AddMvc(options =>
            //{
            //   options.Filters.Add(typeof(HttpAuthAttribute));
            //}).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            services.AddDbContext<eSyaEnterpriseContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("dbContext")));

            services.AddScoped<IBusinessLocationRepository, BusinessLocationRepository>();
            services.AddScoped<IDoctorClinicRepository, DoctorClinicRepository>();
            services.AddScoped<IAppointmentBookingRepository, AppointmentBookingRepository>();
            services.AddScoped<IPatientInfoRepository, PatientInfoRepository>();

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

            app.ConfigureExceptionHandler();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
