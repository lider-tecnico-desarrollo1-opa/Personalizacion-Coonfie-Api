// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthRequest.cs" company="Opa SAS">
//   All rights reserved
// </copyright>
// <summary>
//   Defines the Authorization Request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Opa.Dynamics.Coonfie.Module.Business.Dto.Security
{
    /// <summary>
    /// The Authorization Request 
    /// </summary>
    public class AuthRequest
    {
        /// <summary>
        /// Gets or sets the User Name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the Password
        /// </summary>
        public string Password { get; set; }
    }
}
