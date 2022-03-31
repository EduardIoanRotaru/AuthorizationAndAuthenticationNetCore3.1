using API.Dtos;
using API.Entities.Identity;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}