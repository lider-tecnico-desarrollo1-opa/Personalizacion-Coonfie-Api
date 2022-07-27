
using System;
using System.Collections.Generic;
using System.Text;

namespace Opa.Dynamics.Coonfie.Entities.Business.Dto
{
   public  class GenericError
    {
        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        public string ErrorCode { get; set; }
    }
}
