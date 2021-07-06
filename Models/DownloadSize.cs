using System;
using System.ComponentModel.DataAnnotations;

namespace dwnStats.Models
{   
    public class DownloadSize
    {
        public double downloadSize {get;set;}

        public int hour {get; set;}
    }
}