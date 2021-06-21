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
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _repository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/users
        [HttpGet]
        public ActionResult <IEnumerable<User>> GetAllUsers()
        {
            var userItems = _repository.GetAllUsers();

            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(userItems));
        }
        //GET api/users/{id}
        [HttpGet("{uid}", Name="GetUserById")]
        public ActionResult <UserReadDto> GetUserById(int uid)
        {
            var userItem = _repository.GetUserById(uid);
            if(userItem != null)
            {
                return Ok(_mapper.Map<UserReadDto>(userItem));
            }
            return NotFound();
        }

        

        //DELETE api/users/{uid}
        [HttpDelete("{uid}")]
        public ActionResult UserDelete(int uid)
        {
            var userModelFromRepo = _repository.GetUserById(uid);
            if(userModelFromRepo == null){
                return NotFound();
            }
            
            _repository.DeleteUser(userModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}