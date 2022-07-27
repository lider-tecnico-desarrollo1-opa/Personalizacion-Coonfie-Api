using Opa.Dynamics.Coonfie.Entities.Business.Dto;
using Opa.Dynamics.Coonfie.Module.Business.Adapters;
using Opa.Members.Module.Abstractions.Dal.UnitWork;
using Opa.Members.Module.App.Services.Facades;
using Opa.Members.Module.Entities.Business.Dto.Membership.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opa.Dynamics.Coonfie.Module.Business.WorkFlow
{
   public class MemberWorkFlow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IMembersUnitWork"/> class.
        /// </summary>       
        private Func<IMembersUnitWork> memberUnitworkfactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="IMembersUnitWork"/> class.
        /// </summary>       
        private IMembersUnitWork memberUnitwork;

        public MemberWorkFlow(Func<IMembersUnitWork> memberUnitworkfactory)
        {
            this.memberUnitworkfactory = memberUnitworkfactory;
        }

        public GenericResponse<MemberResponse> GetDatosAsociados(MemberFilter filter)
        {
            
            var member = new MemberFacade(this.memberUnitworkfactory).MemberSearch(
             
                     new Membership
                    {
                        BasicInfo = new BasicInfo
                        {
                            MemberId = filter.DocumentId,
                        }
                    });
            var adapterClient = MembersAdapter.GetMemberAdapter(member);
            return new GenericResponse<MemberResponse>
            {
                Result = true,
                Messages = new List<GenericError>(),
                Object = adapterClient
            };

        }
    }
}
