//Alden Poole
//Parsons Intern Project 2021

using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{
    public class Systems
    {
        [Key]
        public int uid {get;set;}
        [Required]
        public string name {get;set;}
        [Required]
        public double rvTotalSize {get;set;}
        [Required]
        public double lBandSize{get;set;}
        [Required]
        public double sBandSize{get;set;}
    }
}