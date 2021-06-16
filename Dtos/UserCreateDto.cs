//Alden Poole
//Parsons Intern Project 2021

using System.ComponentModel.DataAnnotations;

namespace dwnStats.Dtos
{
    public class UserCreateDto
    {

        [Required]
        public string firstName {get;set;}
        [Required]
        public string lastName {get;set;}
        [Required]
        public string userName{get;set;}
        [Required]
        public string password{get;set;}

        
    }

}