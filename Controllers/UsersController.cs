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
        public ActionResult <IEnumerable<User>> GetAllCommands()
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

        //POST api/users
        [HttpPost]
        public ActionResult<UserReadDto> CreateUser(UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);
            _repository.CreateUser(userModel);
            _repository.SaveChanges();

            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            return CreatedAtRoute("GetUserById", new {uid = userReadDto.uid}, userReadDto);

            //return Ok(userReadDto);
        }
        //PUT api/users/{uid}
        [HttpPut("{uid}")]
        public ActionResult UpdateUser(int uid, UserUpdateDto userUpdateDto)
        {
            var userModelFromRepo = _repository.GetUserById(uid);
            if(userModelFromRepo == null){
                return NotFound();
            }

            _mapper.Map(userUpdateDto, userModelFromRepo);

            _repository.UpdateUser(userModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

          //PATCH api/users/{uid}
        [HttpPatch("{uid}")]
        public ActionResult PartialUserUpdate(int uid, JsonPatchDocument<UserUpdateDto> patchDoc)
        {
            var userModelFromRepo = _repository.GetUserById(uid);
            if(userModelFromRepo == null){
                return NotFound();
            }
            var userToPatch = _mapper.Map<UserUpdateDto>(userModelFromRepo);
            patchDoc.ApplyTo(userToPatch, ModelState);
            if(!TryValidateModel(userToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(userToPatch, userModelFromRepo);

            _repository.UpdateUser(userModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
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