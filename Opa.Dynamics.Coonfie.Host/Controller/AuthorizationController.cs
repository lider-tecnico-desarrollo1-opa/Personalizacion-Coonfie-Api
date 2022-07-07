// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizationController.cs" company="Opa SAS">
//   All rights reserved
// </copyright>
// <summary>
//   Defines the Authorization Controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Opa.Dynamics.Coonfie.Host.Controller
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Opa.Dynamics.Coonfie.Module.Business.Dto.Security;

    /// <summary>
    /// The Authorization Controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AuthorizationController : ControllerBase
    {
        /// <summary>
        /// The request token.
        /// </summary>
        /// <param name="user">
        /// The Auth user.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        /// <response code="200">Token to use other methods</response>
        /// <response code="400">User data malformed</response>
        /// <response code="401">Invalid user credentials</response>   
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [AllowAnonymous]
        public IActionResult GetAuthorizationContext([FromBody] AuthRequest user)
        {
            return this.Ok();
        }
    }
}
