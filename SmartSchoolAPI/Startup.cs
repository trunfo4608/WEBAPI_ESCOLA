using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SmartSchoolAPI.Data;
using Newtonsoft.Json;
using AutoMapper;
using Swashbuckle;


namespace SmartSchoolAPI
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
            services.AddDbContext<SmartSchoolContext>(option =>
                    option.UseSqlServer(Configuration.GetConnectionString("MinhaConexao"))

                );

            

            services.AddControllers()
                .AddNewtonsoftJson(
                opt => opt.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IRepository, Repository>();

            services.AddSwaggerGen(
                    options => {
                        options.SwaggerDoc(
                                    "smartschollapi",
                                    new Microsoft.OpenApi.Models.OpenApiInfo()
                                    {
                                        Title = "SmartSchool API",
                                        Version = "1.0",
                                        Description = "Web API SmartSchool",
                                        Contact = new Microsoft.OpenApi.Models.OpenApiContact
                                        {
                                           Name = "Renato Alves Vasconcelos",
                                           Email = "trunfo4608@gmail.com"
                                          
                                        }

                                    });
                         });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseSwagger()
                .UseSwaggerUI(options => {
                    options.SwaggerEndpoint("/swagger/smartschollapi/swagger.json","smartschoolapi");
                    options.RoutePrefix = "";
                    });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
