//Alden Poole
//Parsons Intern Project 2021

using System;
using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{
    public class DownloadByUser
    {
        public int userID{get;set;}
        public string userName{get;set;}
        public int trajectoryID{get;set;}

        public double downloadSize {get;set;}

        
        
    
    }

}