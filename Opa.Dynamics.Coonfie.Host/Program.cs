// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Opa SAS">
//   All rights reserved
// </copyright>
// <summary>
//   Defines the program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Opa.Dynamics.Coonfie.Host
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The Main
        /// </summary>
        /// <param name="args">The args</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// The Create Host Builder
        /// </summary>
        /// <param name="args">The args</param>
        /// <returns>
        /// The <see cref="IHostBuilder"/>.
        /// </returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
