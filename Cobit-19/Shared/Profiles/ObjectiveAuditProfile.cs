using AutoMapper;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;

namespace Cobit_19.Shared.Profiles
{
    public class ObjectiveAuditProfile : Profile
    {
        public ObjectiveAuditProfile()
        {
            CreateMap<ObjectiveAuditModel, ObjectiveAuditDto>().ReverseMap();
            CreateMap<ObjectiveAuditModel, ObjectiveAuditEditorDto>().ReverseMap();
            CreateMap<ObjectiveAuditMembersModel, ObjectiveAuditMemberEditorDto>().ReverseMap();
            CreateMap<ObjectiveAuditMembersModel, ObjectiveAuditMemberDto>().ReverseMap();
        }
    }
}
