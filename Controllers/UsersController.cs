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
        [HttpGet("GetByUserID/{uid}", Name="GetUserById")]
        public ActionResult <UserReadDto> GetUserById(int uid)
        {
            var userItem = _repository.GetUserById(uid);
            if(userItem != null)
            {
                return Ok(_mapper.Map<UserReadDto>(userItem));
            }
            return NotFound();
        }


        [HttpGet("GetByFirstName/{firstName}")]
        public ActionResult GetByFirstName(string firstName)
        {
            
             
                var result =  _repository.SearchFirst(firstName);
                
                 if(result != null)
            {
                return Ok(_mapper.Map<IEnumerable<UserReadDto>>(result));
            }

                else{
                    return NoContent();
                }

              
        }

        [HttpGet("GetByUsername/{userName}")]
        public ActionResult GetByUserName(string userName)
        {
            
               var result =  _repository.SearchUser(userName);
                
                 if(result != null)
            {
                return Ok(_mapper.Map<IEnumerable<UserReadDto>>(result));
            }

                
                else{
                    return NoContent();
                }

              
        }
        

    
    }

}