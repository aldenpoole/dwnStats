using System.Collections.Generic;
using dwnStats.Models;
using Microsoft.AspNetCore.Mvc;
using dwnStats.Data;

namespace Download.Controllers
{
    //api commands
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _repository;

        public UsersController(IUserRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockUserRepo _repository = new MockUserRepo();
        //GET api/users
        [HttpGet]
        public ActionResult <IEnumerable<User>> GetAllCommands()
        {
            var userItems = _repository.GetAllUsers();

            return Ok(userItems);
        }
        //GET api/users/{id}
        [HttpGet("{id}")]
        public ActionResult <User> GetUserById(string id)
        {
            var userItem = _repository.GetUserById(id);

            return Ok(userItem);
        }
    }

}