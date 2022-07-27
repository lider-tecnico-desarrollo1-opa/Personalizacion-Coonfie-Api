using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opa.Dynamics.Coonfie.Entities.Business.Dto
{
    /// <summary>
    /// Generic Response
    /// </summary>
    public class GenericResponse<TResponse>
    {
        /// <summary>
        /// Gets or sets the object.
        /// </summary>
        [JsonProperty("Respuesta")]
        public TResponse Object { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether result.
        /// </summary>
        [JsonProperty("Resultado")]
        public bool Result { get; set; }

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        [JsonProperty("Mensajes")]
        public ICollection<GenericError> Messages { get; set; }
    }
}
