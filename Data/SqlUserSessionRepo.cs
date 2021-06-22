//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<UserSession>> Search(int userID)
    {
        IQueryable<UserSession> query = _context.UserSessions;
            
        if (userID !=null)
        {
            query = query.Where(e => e.userID.Equals(userID)
                        || e.userID.Equals(userID));
        }

       

        return await query.ToListAsync();
    }

    }
}