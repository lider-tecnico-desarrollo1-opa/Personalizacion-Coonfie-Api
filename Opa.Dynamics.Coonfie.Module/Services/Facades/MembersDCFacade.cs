// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MembersFacade.cs" company="Opa SAS">
//   All rights reserved
// </copyright>
// <summary>
//   Defines the Facade Members .
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using Opa.Dynamics.Coonfie.Dal.Unitwork;
using Opa.Dynamics.Coonfie.Entities.Business.Dto;
using Opa.Dynamics.Coonfie.Module.Business.WorkFlow;
using Opa.Members.Module.Abstractions.Dal.UnitWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opa.Dynamics.Coonfie.Module.Services.Facades
{
    /// <summary>
    /// Members Facade
    /// </summary>
    public class MembersDCFacade : IMembersDCFacade
    {

        private readonly Func<DCUnitwork> unitWorkCd;
        /// <summary>
        /// Initializes a new instance of the <see cref="IDefaultUnitWork"/> class.
        /// </summary>       
        private Func<IMembersUnitWork> memberUnitworkfactory;

        /// <summary>
        /// The Load DefaultUnitWork
        /// </summary>

        public MembersDCFacade(Func<IMembersUnitWork> memberUnitworkfactory)
        {
            this.memberUnitworkfactory = memberUnitworkfactory;
        }

        /// <summary>
        /// Get Datos Asociados
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public GenericResponse<MemberResponse> GetDatosAsociados(MemberFilter filter)
        {
            return new MemberWorkFlow(this.memberUnitworkfactory).GetDatosAsociados(filter);
        }

    }
}
