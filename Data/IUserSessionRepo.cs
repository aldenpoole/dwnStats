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

        Task<IEnumerable<UserSession>> Search(int userID);
        Task<IEnumerable<UserSession>> Search(DateTime timeStart);

    }
}