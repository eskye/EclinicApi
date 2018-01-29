using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using EClinicApi.Models;
using EClinicApi.Data;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using AutoMapper;

namespace EClinicApi
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
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "JwtBearer";
                options.DefaultChallengeScheme = "JwtBearer";
            }).AddJwtBearer("JwtBearer", jwtBearerOptions =>
            {
                jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("VQWHGHHdd2743830chcwefjihw72467823gfwbcwfugf4")),

                    ValidateIssuer = true,
                    ValidIssuer = "Eclinic",

                    ValidateAudience = true,
                    ValidAudience = "Eclinic_Client",

                    ValidateLifetime = true, //validate the expiration and not before values in the token

                    ClockSkew = TimeSpan.FromMinutes(5), //5 minute tolerance for the expiration date
                     



                };
            });
            services.AddAutoMapper();
            services.AddDbContext<EclinicData>(optionsAction => optionsAction.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=SuperAdmin}/{action=GetUserData}/{id?}");
            });

            
        }
    }
}
