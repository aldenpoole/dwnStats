//Alden Poole
//Parsons Intern Project 2021

using System.Collections.Generic;
using dwnStats.Models;
using Microsoft.AspNetCore.Mvc;
using dwnStats.Data;
using AutoMapper;
using dwnStats.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Download.Controllers
{
    //api commands
    [Route("api/usersessions")]
    [ApiController]
    public class UserSessionsController : ControllerBase
    {
        private readonly IUserSessionRepo _repository;
        private readonly IMapper _mapper;

        public UserSessionsController(IUserSessionRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/usersessions
        [HttpGet]
        public ActionResult <IEnumerable<UserSession>> GetAllUserSessions()
        {
            var userSessionItems = _repository.GetAllUserSessions();

            return Ok(_mapper.Map<IEnumerable<UserSessionReadDto>>(userSessionItems));
        }
        //GET api/usersessions/{id}
        [HttpGet("{uid}", Name="GetUserSessionsById")]
        public ActionResult <UserSessionReadDto> GetUserSessionsById(int uid)
        {
            var userSessionsItem = _repository.GetUserSessionsById(uid);
            if(userSessionsItem != null)
            {
                return Ok(_mapper.Map<UserSessionReadDto>(userSessionsItem));
            }
            return NotFound();
        }

        [HttpGet("{search}/{userID}")]
        public async Task<ActionResult<IEnumerable<UserSession>>> Search(int userID)
        {
            try
            {
                var result = await _repository.Search(userID);

                if (result.Any())
                {
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
    }

        
    }
}