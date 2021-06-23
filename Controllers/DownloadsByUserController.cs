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
    [Route("api/downloadsbyuser")]
    [ApiController]
    public class DownloadsByUserController : ControllerBase
    {
        private readonly IDownloadsByUserRepo _repository;
        private readonly IMapper _mapper;

        public DownloadsByUserController(IDownloadsByUserRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
       
        [HttpGet("GetDownloadByUserID/{userID}")] // <--
        public ActionResult GetDownloadByUserID(int userID)
            {       
                var result =  _repository.SearchDownloadsByUserID(userID);
                
                 if(result != null)
            {
                return Ok(result);
            }

                
                else{
                    return NoContent();
                }
            }
        
    }
}