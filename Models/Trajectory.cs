//Alden Poole
//Parsons Intern Project 2021

using System;
using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{
    public class Trajectory
    {
        [Key]
        public int uid {get;set;}

        [Required]
        public int systemID {get;set;}

        [Required]
        public string name {get;set;}

        [Required]
        public DateTime launchTime {get;set;}

        [Required]
        public string launchCountry{get;set;}

        [Required]
        public string launchLocation{get;set;}
        
    
    }

}