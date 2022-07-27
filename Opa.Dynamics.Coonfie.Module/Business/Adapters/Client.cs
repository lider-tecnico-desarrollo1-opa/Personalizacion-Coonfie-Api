using Opa.Dynamics.Coonfie.Entities.Business.Dto;
using Opa.Members.Module.Entities.Business.Dto;
using Opa.Members.Module.Entities.Business.Dto.Membership.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opa.Dynamics.Coonfie.Module.Business.Adapters
{
   public static class MembersAdapter
    {
        /// <summary>
        /// The Get Product Simulate.
        /// </summary>
        /// <param name="Product">
        /// The simulate request
        /// </param>
        /// <returns>
        /// The <see cref="GetProductAdapter"/>.
        /// </returns>
        public static MemberResponse GetMemberAdapter(MembersStandardResult<Membership> member)
        {
            return new MemberResponse()
            {
                AnalystCode = member.Entity.BasicInfo.AnalystCode,
                AnalystRoute = member.Entity.BasicInfo.AnalystRoute,
                CellPhone = member.Entity.BasicInfo.CellPhone,
                ContractType = member.Entity.BasicInfo.ContractType,
                DateBinding = member.Entity.BasicInfo.DateBinding,
                DateBirth = member.Entity.BasicInfo.DateBirth,
                DateEmployment = member.Entity.BasicInfo.DateEmployment,
                EconomicActivityCode = member.Entity.BasicInfo.EconomicActivityCode,
                EconomicActivityDivisionCode = member.Entity.BasicInfo.EconomicActivityDivisionCode,
                EducationLevel = member.Entity.BasicInfo.EducationLevel,
                Email = member.Entity.BasicInfo.Email,
                FirstLastName = member.Entity.BasicInfo.FirstLastName,
                Gender = member.Entity.BasicInfo.Gender,
                GracePeriod = member.Entity.BasicInfo.GracePeriod,
                HousingType = member.Entity.BasicInfo.HousingType,
                LastUpdate = member.Entity.BasicInfo.LastUpdate,
                MaritalStatus = member.Entity.BasicInfo.MaritalStatus,
                MemberId = member.Entity.BasicInfo.MemberId,
                MemberType = member.Entity.BasicInfo.MemberType,
                FirstName = member.Entity.BasicInfo.FirstName,
                NumberDependentPersons = member.Entity.BasicInfo.NumberDependentPersons,
                Office = member.Entity.BasicInfo.Office,
                OfficeName = member.Entity.BasicInfo.OfficeName,
                PenalizedLoan = member.Entity.BasicInfo.PenalizedLoan,
                Pep = member.Entity.BasicInfo.Pep,
                Privileged = (member.Entity.BasicInfo.Manager == true || member.Entity.BasicInfo.RelativeOfManager == true) ? true : false,
                ResidenceAddress = member.Entity.BasicInfo.ResidenceAddress,
                ResidenceCity = member.Entity.BasicInfo.ResidenceCity,
                ResidencePhone = member.Entity.BasicInfo.ResidencePhone,
                ResidenceState = member.Entity.BasicInfo.ResidenceState,
                RestructuredLoan = member.Entity.BasicInfo.RestructuredLoan,
                SecondName = member.Entity.BasicInfo.SecondName,
                SecondLastName = member.Entity.BasicInfo.SecondLastName,
                State = member.Entity.BasicInfo.State,
                Stratum = member.Entity.BasicInfo.Stratum,
                TotalAssets = member.Entity.BasicInfo.TotalAssets,
                WorkCompanyName = member.Entity.BasicInfo.WorkCompanyName
            };
        }
}
}