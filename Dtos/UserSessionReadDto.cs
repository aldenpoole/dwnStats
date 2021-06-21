//Alden Poole
//Parsons Intern Project 2021
using System;
using System.Data.SqlClient;

namespace dwnStats.Dtos
{
    public class UserSessionReadDto
    {
      
        public int uid {get;set;}

   
        public int filterID {get;set;}

   
        public int userID {get;set;}

        public DateTime timeStart {get;set;}

    
        public DateTime  timeEnd {get;set;}
        
    
        public string ipAddress {get;set;}
        
    
    }

}