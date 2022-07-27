using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opa.Dynamics.Coonfie.Entities.Business.Dto
{
    public class MemberResponse
    {
        [JsonProperty("PrimerNombre")]
        public string FirstName { get; set; }

        [JsonProperty("SegundoNombre")]
        public string SecondName { get; set; }

        [JsonProperty("PrimerApellido")]
        public string FirstLastName { get; set; }

        [JsonProperty("SegundoApellido")]
        public string SecondLastName { get; set; }

        [JsonProperty("FechaNacimiento")]
        public DateTime DateBirth { get; set; }

        [JsonProperty("UltimaActualizacion")]
        public DateTime LastUpdate { get; set; }

        [JsonProperty("Genero")]
        public string Gender { get; set; }

        [JsonProperty("CedulaAsociado")]
        public string MemberId { get; set; }

        [JsonProperty("Agencia")]
        public int Office { get; set; }

        [JsonProperty("NombreAgencia")]
        public string OfficeName { get; set; }

        [JsonProperty("CodigoActividadEconomica")]
        public string EconomicActivityCode { get; set; }

        [JsonProperty("CodigoDivisionActividadEconomica")]
        public string EconomicActivityDivisionCode { get; set; }

        [JsonProperty("CodigoAnalista")]
        public string AnalystCode { get; set; }

        [JsonProperty("RutaAnalista")]
        public string AnalystRoute { get; set; }

        [JsonProperty("Estado")]
        public string State { get; set; }

        [JsonProperty("TipoAsociado")]
        public string MemberType { get; set; }

        [JsonProperty("Celular")]
        public string CellPhone { get; set; }

        [JsonProperty("Correo")]
        public string Email { get; set; }

        [JsonProperty("DepartamentoResidencia")]
        public string ResidenceState { get; set; }

        [JsonProperty("CiudadResidencia")]
        public string ResidenceCity { get; set; }

        [JsonProperty("DireccionResidencia")]
        public string ResidenceAddress { get; set; }

        [JsonProperty("TelefonoResidencia")]
        public string ResidencePhone { get; set; }

        [JsonProperty("FechaVinculacion")]
        public DateTime DateBinding { get; set; }

        [JsonProperty("TipoVivienda")]
        public string HousingType { get; set; }

        [JsonProperty("Estrato")]
        public string Stratum { get; set; }

        [JsonProperty("EstadoCivil")]
        public string MaritalStatus { get; set; }

        [JsonProperty("TipoContrato")]
        public string ContractType { get; set; }

        [JsonProperty("FechaIngresoLaboral")]
        public DateTime DateEmployment { get; set; }

        [JsonProperty("NombreEmpresaLabora")]
        public string WorkCompanyName { get; set; }

        [JsonProperty("NivelEducativo")]
        public string EducationLevel { get; set; }

        [JsonProperty("NumeroPersonasCargo")]
        public byte NumberDependentPersons { get; set; }

        [JsonProperty("CreditosReestructurado")]
        public bool RestructuredLoan { get; set; }

        [JsonProperty("CreditosCastigados")]
        public bool PenalizedLoan { get; set; }

        [JsonProperty("Pep")]
        public bool Pep { get; set; }

        [JsonProperty("CreditosPeriodoGracia")]
        public bool GracePeriod { get; set; }

        [JsonProperty("TotalIngresos")]
        public decimal TotalAssets { get; set; }

        [JsonProperty("Privilegiado")]
        public bool Privileged { get; set; }
    }
}
