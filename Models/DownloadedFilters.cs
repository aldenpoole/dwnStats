//Alden Poole
//Parsons Intern Project 2021

using System;
using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{
    public class DownloadedFilters
    {
        [Key]
       
        [Required]
        public string launchCountry{get;set;}
        public int downloadID{get;set;}

        public DateTime downloadTime{get;set;}

        public int userID{get;set;}
    }

}