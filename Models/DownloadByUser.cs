//Alden Poole
//Parsons Intern Project 2021

using System;
using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{   
    public class DownloadByUser
    {
        public double downloadSize {get;set;}
        public int trajectoryID{get;set;}
        public DateTime downloadTime {get;set;}
    }
}