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
    [Route("api/filters")]
    [ApiController]
    public class FilterController : ControllerBase
    {
        private readonly IFilterRepo _repository;
        private readonly IMapper _mapper;

        public FilterController(IFilterRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/filters
        [HttpGet]
        public ActionResult <IEnumerable<Filter>> GetAllFilters()
        {
            var filterItems = _repository.GetAllFilters();

            return Ok(_mapper.Map<IEnumerable<FilterReadDto>>(filterItems));
        }
        //GET api/filters/{id}
        [HttpGet("{uid}", Name="GetFiltersById")]
        public ActionResult <FilterReadDto> GetFiltersById(int uid)
        {
            var filtersItem = _repository.GetFiltersById(uid);
            if(filtersItem != null)
            {
                return Ok(_mapper.Map<FilterReadDto>(filtersItem));
            }
            return NotFound();
        }
    }
}