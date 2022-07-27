// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MembersFacade.cs" company="Opa SAS">
//   All rights reserved
// </copyright>
// <summary>
//   Defines the Facade Members .
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using Opa.Dynamics.Coonfie.Entities.Business.Dto;

namespace Opa.Dynamics.Coonfie.Module.Services.Facades
{
    public interface IMembersDCFacade
    {
        GenericResponse<MemberResponse> GetDatosAsociados(MemberFilter filter);
        //MemberResponse GetDatosAsociados(MemberFilter filter);
    }
}