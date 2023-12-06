using AutoMapper;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;

namespace Cobit_19.Shared.Profiles
{
    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {
            CreateMap<AnswerModel, AnswerDto>().ReverseMap();
            CreateMap<AnswerModel, AnswerEditorDto>().ReverseMap();
        }
    }
}
