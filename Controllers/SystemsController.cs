//Alden Poole
//Parsons Intern Project 2021

using System.Collections.Generic;
using dwnStats.Models;
using Microsoft.AspNetCore.Mvc;
using dwnStats.Data;
using AutoMapper;
using dwnStats.Dtos;
using Microsoft.AspNetCore.JsonPatch;

namespace Download.Controllers
{
    //api commands
    [Route("api/systems")]
    [ApiController]
    public class SystemsController : ControllerBase
    {
        private readonly ISystemsRepo _repository;
        private readonly IMapper _mapper;

        public SystemsController(ISystemsRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult <IEnumerable<Systems>> GetAllSystems()
        {
            var systemsItems = _repository.GetAllSystems();

            return Ok(_mapper.Map<IEnumerable<SystemsReadDto>>(systemsItems));
        }
        
        [HttpGet("{uid}", Name="GetSystemsById")]
        public ActionResult <SystemsReadDto> GetSystemsById(int uid)
        {
            var systemsItem = _repository.GetSystemsById(uid);
            if(systemsItem != null)
            {
                return Ok(_mapper.Map<SystemsReadDto>(systemsItem));
            }
            return NotFound();
        }
    }
}