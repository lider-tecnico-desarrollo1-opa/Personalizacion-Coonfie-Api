using Microsoft.Extensions.Configuration;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Opa.Dynamics.Coonfie.Entities.Services.Configuration
{
    using Microsoft.Extensions.Configuration;
    public class MembersConfiguration
    {
        /// <summary>
        /// The instance.
        /// </summary>
        public static MembersConfiguration Instance => instance ?? (instance = new MembersConfiguration());

       
        /// <summary>
        /// The member connection string.
        /// </summary>
        public string IntegradorDC => this.configuration.GetConnectionString(this.GetValueSection<string>("IntegradorDC"));

        public object Configuration { get; private set; }

        /// <summary>
        /// The instance.
        /// </summary>
        private static MembersConfiguration instance;

        /// <summary>
        /// The configuration.
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// Prevents a default instance of the <see cref="MembersConfiguration"/> class from being created.
        /// </summary>
        private MembersConfiguration()
        {
            this.configuration = new ConfigurationBuilder()               
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public T GetValueSection<T>(string settingsKey)
        {
            return this.configuration.GetSection("AppSettings").GetValue<T>(settingsKey);
        }
        /// <summary>
        /// The get setting value.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <typeparam name="T">
        /// type to return 
        /// </typeparam>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public T GetSettingValue<T>(string key)
        {
            return this.configuration.GetSection("appSettings").GetValue<T> (key);
        }

        /// <summary>
        /// The get culture message.
        /// </summary>
        /// <param name="stringKey">
        /// The string key.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        //public string GetCultureMessage(string stringKey)
        //{
        //    Thread.CurrentThread.CurrentCulture = new CultureInfo(this.GetSettingValue<string>("defaultCulture"));
        //    Thread.CurrentThread.CurrentUICulture = new CultureInfo(this.GetSettingValue<string>("defaultCulture"));

        //    return string.IsNullOrEmpty(Lang.ResourceManager.GetString(stringKey))
        //               ? $"{stringKey}: Undefined"
        //               : Lang.ResourceManager.GetString(stringKey);
        //}
    }
}
