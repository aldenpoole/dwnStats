//Alden Poole
//Parsons Intern Project 2021

using System;
using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{
    public class Filter
    {
        [Key]
        public int uid {get;set;}
        [Required]
        public string launchCountry{get;set;}
        [Required]
        public string launchLocation{get;set;}
        [Required]
        public DateTime launchTime {get;set;}
    }

}