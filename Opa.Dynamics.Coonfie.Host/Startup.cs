// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Opa SAS">
//   All rights reserved
// </copyright>
// <summary>
//   Defines the Startup.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Opa.Dynamics.Coonfie.Host
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Opa.Dinamycs.Coonfie.Host.Extensions;
    using Opa.Dynamics.Coonfie.Host.Extensions;

    /// <summary>
    /// The Startup
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The configuration</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// The Configure Services.
        /// </summary>
        /// <param name="services">The services collection</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .RegisterSwagger()
                .RegisterCors()
                .RegisterCustomizeServices()
                .AddMvc(options => options.EnableEndpointRouting = false);
        }

        /// <summary>
        /// The configure
        /// </summary>
        /// <param name="app">The application builder</param>
        /// <param name="env">The host environment</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(
                    builder => builder
                    .SetIsOriginAllowed(origin => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials())
                    .ConfigureSwagger()
                .UseStaticFiles()
                .UseMvc();
        }
    }
}
