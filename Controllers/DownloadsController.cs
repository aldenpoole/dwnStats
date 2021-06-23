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
    [Route("api/downloads")]
    [ApiController]
    public class DownloadsController : ControllerBase
    {
        private readonly IDownloadsRepo _repository;
        private readonly IMapper _mapper;

        public DownloadsController(IDownloadsRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult <IEnumerable<Downloads>> GetAllDownloads()
        {
            var downloadItems = _repository.GetAllDownloads();

            return Ok(_mapper.Map<IEnumerable<DownloadReadDto>>(downloadItems));
        }
      
        [HttpGet("{uid}", Name="GetUserDownloadsById")]
        public ActionResult <DownloadReadDto> GetDownloadsById(int uid)
        {
            var downloadsItem = _repository.GetDownloadsById(uid);
            if(downloadsItem != null)
            {
                return Ok(_mapper.Map<DownloadReadDto>(downloadsItem));
            }
            return NotFound();
        }
         [HttpGet("GetDownloadBySessionID/{sessionID}")]
        public ActionResult GetDownloadBySessionID(int sessionID)
            {       
                var result =  _repository.SearchBySessionID(sessionID);
                if(result != null)
                {
                    return Ok(_mapper.Map<IEnumerable<DownloadReadDto>>(result));
                }
                else
                {
                    return NoContent();
                }
            }
        
    }
}