//Alden Poole
//Parsons Intern Project 2021

using System;
using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{
    public class UserSession
    {
        [Key]
        public int uid {get;set;}
        [Required]
        public int filterID {get;set;}
        [Required]
        public int userID {get;set;}
        [Required]
        public DateTime  timeStart {get;set;}
        [Required]
        public DateTime  timeEnd {get;set;}
        [Required]
        public string ipAddress {get;set;}
    }
}