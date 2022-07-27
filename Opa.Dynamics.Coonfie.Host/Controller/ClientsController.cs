using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Opa.Dynamics.Coonfie.Entities.Business.Dto;
using Opa.Dynamics.Coonfie.Module.Services.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opa.Dynamics.Coonfie.Host.Controller
{

    /// <summary>
    /// The clients controller.
    /// </summary> 
    [Route("api/[controller]")]
    [ApiController]
    
    public class ClientsController : ControllerBase
    {

        private readonly IMembersDCFacade membersDCFacade;
        /// <summary>
        ///  Clients Controller
        /// </summary>
        /// <param name="membersDCFacade"></param>
        public ClientsController(IMembersDCFacade membersDCFacade)
        {
            this.membersDCFacade = membersDCFacade;
        }

        /// <summary>
        /// Get Client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        [HttpPost("Asociado")]        
        [ProducesResponseType(typeof(GenericResponse<MemberResponse>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        public IActionResult GetClient([ FromBody ] MemberFilter client)
        {
            var result = this.membersDCFacade.GetDatosAsociados(client);
            return this.Ok(new GenericResponse<MemberResponse>
            {
                Object = result.Object,
                Result = result.Result,
                Messages = result.Messages
            });
        }
    }
}
