using AutoMapper;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;

namespace Cobit_19.Shared.Profiles
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditModel, AuditDto>()
                .ForMember(a => a.User, o => o.MapFrom(a => a.ApplicationUser));
            CreateMap<AuditDto, AuditModel>()
                .ForMember(a => a.ApplicationUser, o => o.MapFrom(a => a.User));

            CreateMap<AuditEditorDto, AuditModel>()
                .ForMember(a => a.ApplicationUserID, o => o.MapFrom(a => a.UserID));
        }
    }
}
