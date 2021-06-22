//Alden Poole
//Parsons Intern Project 2021

using System;
using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{
    public class DownloadByUser
    {
        [Key]
        public int userID{get;set;}


        [Required]
        public double downloadSize {get;set;}

        
        
    
    }

}