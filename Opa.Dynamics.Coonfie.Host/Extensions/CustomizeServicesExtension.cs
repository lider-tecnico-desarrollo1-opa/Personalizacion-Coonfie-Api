// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomizeServicesExtension.cs" company="Opa SAS">
//   All rights reserved
// </copyright>
// <summary>
//   Defines the Customize Services Extension.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Opa.Dinamycs.Coonfie.Host.Extensions
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.Extensions.DependencyInjection;
    using Opa.Dynamics.Coonfie.Module.Services.Facades;
    using Opa.Members.Module.Dal.Dal.UnitWork;

    /// <summary>
        /// The module facade extension.
        /// </summary>
    public static class CustomizeServicesExtension
    {
        /// <summary>
        /// The register services.
        /// </summary>
        /// <param name="services">
        /// The services.
        /// </param>
        /// <returns>
        /// The <see cref="IServiceCollection"/>.
        /// </returns>
        public static IServiceCollection RegisterCustomizeServices(this IServiceCollection services)
        {
            services            
            .AddSingleton<IMembersDCFacade, MembersDCFacade>(f => new MembersDCFacade(MembersUnitWork.UnitWorkFactory()));            
            return services;
        }
    }
}


//{
//    services
//        .AddSingleton<ICreditosFacade, CreditosFacade>(f => new CreditosFacade(() => new CdUnitwork(new CdContext()), () => new LoanDefaultUnitWork(), SavingUnitWork.UnitWorkFactory()))
//        .AddSingleton<IGestionFacade, GestionFacade>(f => new GestionFacade(() => new CdUnitwork(new CdContext()), () => new LoanDefaultUnitWork(), MembersUnitWork.UnitWorkFactory(), SavingUnitWork.UnitWorkFactory()))
//        .AddSingleton<IAuthorizationHandler, CdProfilePolicyHandler>()
//        .AddSingleton<ITransactionalReceiverFacade, TransactionalReceiverFacade>();

//    return services;
//}