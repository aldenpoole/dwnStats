//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dwnStats.Data
{
    public class SqlUserSessionRepo : IUserSessionRepo
    {
        private readonly UserSessionContext _context;

        public SqlUserSessionRepo(UserSessionContext context)
        {
            _context = context;
        }

        public IEnumerable<UserSession> GetAllUserSessions()
        {
            return _context.UserSessions.ToList();
        }

        public UserSession GetUserSessionsById(int id)
        {
           return _context.UserSessions.FirstOrDefault(p => p.uid == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}