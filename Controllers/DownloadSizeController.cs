//Alden Poole
//Parsons Intern Project 2021

using System.Collections.Generic;
using dwnStats.Models;
using Microsoft.AspNetCore.Mvc;
using dwnStats.Data;
using AutoMapper;
using dwnStats.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using System;

namespace Download.Controllers
{
    //api commands
    [Route("api/downloadsizes")]
    [ApiController]
    
    public class DownloadSizeController : ControllerBase
    {
        private readonly IDownloadsSizeRepo _repository;
        private readonly IMapper _mapper;

        public DownloadSizeController(IDownloadsSizeRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
       
        [HttpGet]
        public ActionResult GetPastDaysDownloads()
        {
            var result =  _repository.GetPastDaysDownloads();
            if(result != null)
            {
                return Ok(result);
            }        
            else
            {
                return StatusCode(204);
            }
        }

    }
}