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
    [Route("api/trajectories")]
    [ApiController]
    public class TrajectoryController : ControllerBase
    {
        private readonly ITrajectoryRepo _repository;
        private readonly IMapper _mapper;

        public TrajectoryController(ITrajectoryRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/trajectories
        [HttpGet]
        public ActionResult <IEnumerable<Trajectory>> GetAllTrajectories()
        {
            var trajectoryItems = _repository.GetAllTrajectories();

            return Ok(_mapper.Map<IEnumerable<TrajectoryReadDto>>(trajectoryItems));
        }
        //GET api/trajectories/{id}
        [HttpGet("{uid}", Name="GetTrajectoriesById")]
        public ActionResult <TrajectoryReadDto> GetTrajectoriesById(int uid)
        {
            var trajectoriesItem = _repository.GetTrajectoriesById(uid);
            if(trajectoriesItem != null)
            {
                return Ok(_mapper.Map<TrajectoryReadDto>(trajectoriesItem));
            }
            return NotFound();
        }
    }
}