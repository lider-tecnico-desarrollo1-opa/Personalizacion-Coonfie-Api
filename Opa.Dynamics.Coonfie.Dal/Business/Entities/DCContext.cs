using Microsoft.EntityFrameworkCore;
using Opa.Dynamics.Coonfie.Entities.Services.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opa.Dynamics.Coonfie.Dal.Business.Entities
{
    
    public class DCContext: DbContext
    {
        /// <summary>
        /// DC Context
        /// </summary>
        public DCContext()
        {
        }

        /// <summary>
        /// init DCContext
        /// </summary>
        /// <param name="options"></param>
        public DCContext(DbContextOptions<DCContext> options) : base(options)
        {
        }

        /// <summary>
        /// On Configuring
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(MembersConfiguration.Instance.IntegradorDC);
        }
    }
}
