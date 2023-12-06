using AutoMapper;

namespace Cobit_19.Shared.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Data.Models.ApplicationUser, Dtos.UserDto>().ReverseMap();
        }
    }
}
