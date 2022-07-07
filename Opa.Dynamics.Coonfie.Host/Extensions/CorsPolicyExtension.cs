// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CorsPolicyExtension.cs" company="Opa SAS">
//   All rights reserved
// </copyright>
// <summary>
//   Defines the Cors Policy Extension Services.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Opa.Dynamics.Coonfie.Host.Extensions
{
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// The cross origin policy extension.
    /// </summary>
    public static class CorsPolicyExtension
    {
        /// <summary>
        /// The register cross origin.
        /// </summary>
        /// <param name="services">
        /// The services.
        /// </param>
        /// <returns>
        /// The <see cref="IServiceCollection"/>.
        /// </returns>
        public static IServiceCollection RegisterCors(this IServiceCollection services)
        {
            services.AddCors(
                options =>
                {
                    options.AddPolicy(
                        "AllOrigins",
                        builder =>
                        {
                            builder
                                .AllowAnyHeader()
                                .AllowAnyMethod()
                                .AllowAnyOrigin();
                        });
                });

            return services;
        }
    }
}
