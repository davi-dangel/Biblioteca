using Biblioteca.Api.IoC;
using Biblioteca.Repository.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FluentValidation.AspNetCore;
using System;
using Biblioteca.Domain.Mapper;

namespace Biblioteca
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
            services.AddControllers().AddFluentValidation(fv =>
            {
                fv.DisableDataAnnotationsValidation = false;
                fv.RegisterValidatorsFromAssemblyContaining<Startup>();
            });

            services.ResolveRepositoryDependencies();
            services.ResolveApplicationDependencies();
            services.ResolveValidationDependencies();

            services.AddScoped<MongoDBContext>();

            MongoDBContext.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
            MongoDBContext.DatabaseName = Configuration.GetSection("MongoConnection:Database").Value;
            MongoDBContext.IsSSL = Convert.ToBoolean(this.Configuration.GetSection("MongoConnection:IsSSL").Value);

            services.MapperConfig();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
