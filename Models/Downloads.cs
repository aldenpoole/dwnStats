//Alden Poole
//Parsons Intern Project 2021

using System;
using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{
    public class Downloads
    {
        [Key]
        public int uid {get;set;}

        [Required]
        public int sessionID {get;set;}

        [Required]
        public int trajectoryID {get;set;}

        [Required]
        public double downloadSize {get;set;}

        [Required]
        public DateTime downloadTime{get;set;}
        
    
    }

}