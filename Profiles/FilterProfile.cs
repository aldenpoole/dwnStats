//Alden Poole
//Parsons Intern Project 2021

using AutoMapper;
using dwnStats.Dtos;
using dwnStats.Models;

namespace dwnStats.Profiles
{
    public class FilterProfile : Profile
    {
        public FilterProfile()
        {
            //source -> target... reading user from database, passing back to client as dto
            CreateMap<Filter, FilterReadDto>();
        }
    }
}