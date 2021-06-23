//Alden Poole
//Parsons Intern Project 2021

using System;

namespace dwnStats.Models
{
    public class TrajectoryReadDto
    {
        public int uid {get;set;}
        public int systemID {get;set;}
        public string name {get;set;}
        public DateTime launchTime {get;set;}
        public string launchCountry{get;set;}
        public string launchLocation{get;set;}
    }
}