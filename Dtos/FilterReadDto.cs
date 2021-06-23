//Alden Poole
//Parsons Intern Project 2021

using System;

namespace dwnStats.Models
{
    public class FilterReadDto
    {
        public int uid {get;set;}
        public string launchCountry{get;set;}
        public string launchLocation{get;set;}
        public DateTime launchTime {get;set;}
    }
}