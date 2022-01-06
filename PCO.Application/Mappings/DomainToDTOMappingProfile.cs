using AutoMapper;
using PCO.Application.DTOs;
using PCO.Domain.Entities;

namespace PCO.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
