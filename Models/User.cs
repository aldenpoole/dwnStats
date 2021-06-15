using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{
    public class User
    {
        [Key]
        public int uid {get;set;}

        [Required]
        [MaxLength(64)]
        public string firstName {get;set;}

        [Required]
        public string lastName {get;set;}

        [Required]
        public string userName{get;set;}

        [Required]
        public string password{get;set;}
        
    
    }

}