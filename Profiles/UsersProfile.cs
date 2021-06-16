using AutoMapper;
using dwnStats.Dtos;
using dwnStats.Models;

namespace dwnStats.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserReadDto>();
        }
    }
}