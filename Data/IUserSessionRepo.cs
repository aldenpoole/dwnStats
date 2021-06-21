//Alden Poole
//Parsons Intern Project 2021

using System.Collections.Generic;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface IUserSessionRepo
    {
        
        bool SaveChanges();
        IEnumerable<UserSession> GetAllUserSessions();
        UserSession GetUserSessionsById(int uid);
    }
}