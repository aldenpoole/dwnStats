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
        //private readonly DownloadsContext _downloadsContext;

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

        public IEnumerable<UserSession> SearchByUserID(int userID)
        {
            IEnumerable<UserSession> sessions = from tr in _context.UserSessions
                   where tr.userID == userID
                   select tr;
            return sessions.ToList();
      
        }

        public IEnumerable<UserSession> SearchByDateTime(DateTime dateTime)
        {
            IEnumerable<UserSession> sessions = from tr in _context.UserSessions
                   where tr.timeStart == dateTime
                   select tr;
            return sessions.ToList();
      
        }

        /*public IEnumerable<DownloadByUser> DownloadsByUser(int uid, int userID)
        {
            IEnumerable<UserSession> sessions = from tr in _context.UserSessions
                   where tr.userID == userID
                   select tr;
            IEnumerable<Downloads> downloads = from dr in _downloadsContext.Downloads
                    where dr.sessionID == uid
                    select dr;
            sessions.ToList();
            downloads.ToList();

           IEnumerable<DownloadByUser> innerJoin = (IEnumerable<DownloadByUser>)sessions.Join(// outer sequence 
                      downloads,  // inner sequence 
                      session => session.uid,    // outerKeySelector
                      download => download.sessionID,  // innerKeySelector
                      (session, download) => new  // result selector
                                    {
                                        userID = session.userID,
                                        downloadSize = download.downloadSize
                                    });
            return innerJoin.ToList();
      
        }*/

       

    }
}