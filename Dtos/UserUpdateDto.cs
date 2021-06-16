using System.ComponentModel.DataAnnotations;

namespace dwnStats.Dtos
{
    public class UserUpdateDto
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