//Alden Poole
//Parsons Intern Project 2021

using AutoMapper;
using dwnStats.Dtos;
using dwnStats.Models;

namespace dwnStats.Profiles
{
    public class DownloadsProfile : Profile
    {
        public DownloadsProfile()
        {
            //source -> target... reading user from database, passing back to client as dto
            CreateMap<Downloads, DownloadReadDto>();
        }
    }
}