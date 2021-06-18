//Alden Poole
//Parsons Intern Project 2021

using AutoMapper;
using dwnStats.Dtos;
using dwnStats.Models;

namespace dwnStats.Profiles
{
    public class SystemsProfile : Profile
    {
        public SystemsProfile()
        {
            //source -> target... reading user from database, passing back to client as dto
            CreateMap<Systems, SystemsReadDto>();
        }
    }
}