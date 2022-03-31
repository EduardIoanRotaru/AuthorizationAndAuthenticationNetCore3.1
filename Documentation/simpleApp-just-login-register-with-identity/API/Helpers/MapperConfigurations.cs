using API.Models.dto.requests;
using AutoMapper;

namespace API.Helpers
{
    public class MapperConfigurations : Profile
    {
        public MapperConfigurations()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}