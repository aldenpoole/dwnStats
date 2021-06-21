//Alden Poole
//Parsons Intern Project 2021

using AutoMapper;
using dwnStats.Dtos;
using dwnStats.Models;

namespace dwnStats.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            //source -> target... reading user from database, passing back to client as dto
            CreateMap<User, UserReadDto>();
        }
    }
}