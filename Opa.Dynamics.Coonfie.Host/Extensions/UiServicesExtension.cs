// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UiServicesExtension.cs" company="Opa SAS">
//   All rights reserved
// </copyright>
// <summary>
//   Defines the User Interface Services Extension.
// </summary>

namespace Opa.Dynamics.Coonfie.Host.Extensions
{
    using System;
    using System.IO;
    using System.Reflection;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.OpenApi.Models;    

    /// <summary>
    /// The User Interface Services Extension
    /// </summary>
    public static class UiServicesExtension
    {
        /// <summary>
        /// The register swagger.
        /// </summary>
        /// <param name="services">
        /// The services.
        /// </param>
        /// <returns>
        /// The <see cref="IServiceCollection"/>.
        /// </returns>
        public static IServiceCollection RegisterSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc(
                        "v1", 
                        new OpenApiInfo
                        {
                            Title = $"Cooptenjo API v1",
                            Version = "v1",
                            Description = "Cooptenjo API",
                            Contact = new OpenApiContact 
                            {
                                Name = "Cooptenjo",
                                Email = string.Empty,
                                Url = new Uri("https://www.cooptenjo.com/"),
                            },
                    });

                    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
                });

            return services;
        }

        /// <summary>
        /// The configure swagger.
        /// </summary>
        /// <param name="app">
        /// The app.
        /// </param>
        /// <returns>
        /// The <see cref="IApplicationBuilder"/>.
        /// </returns>
        public static IApplicationBuilder ConfigureSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(
                c =>
                {
                    c.SwaggerEndpoint("./swagger/v1/swagger.json", "Cooptenjo API v1");
                    c.RoutePrefix = string.Empty;
                });

            return app;
        }
    }
}
