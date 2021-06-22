//Alden Poole
//Parsons Intern Project 2021

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface IUserSessionRepo
    {
        
        bool SaveChanges();
        IEnumerable<UserSession> GetAllUserSessions();
        UserSession GetUserSessionsById(int uid);
        IEnumerable<UserSession> SearchByUserID(int userID);
         IEnumerable<UserSession> SearchByDateTime(DateTime dateTime);


    }
}