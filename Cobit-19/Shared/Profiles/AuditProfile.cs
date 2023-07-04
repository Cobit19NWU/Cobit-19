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
                .ForMember(d => d.Answers, opt => opt.MapFrom(s => s.Answers))
                .ForMember(d => d.DateCompleted, opt => opt.MapFrom(s => s.DateCompleted))
                .ForMember(d => d.DateCreated, opt => opt.MapFrom(s => s.DateCreated))
                .ForMember(d => d.FocusAreaID, opt => opt.MapFrom(s => s.FocusAreaID))
                .ForMember(d => d.ID, opt => opt.MapFrom(s => s.ID))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status))
                .ForMember(d => d.UserID, opt => opt.MapFrom(s => s.ApplicationUserID));
        }
    }
}
