//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dwnStats.Data
{
    public class SqlDownloadsByUserRepo : IDownloadsByUserRepo
    {
        private readonly DownloadsContext _context;
        private readonly UserContext _userContext;
        private readonly UserSessionContext _sessionContext;

        public SqlDownloadsByUserRepo(DownloadsContext context, UserContext userContext, UserSessionContext sessionContext)
        {
            _context = context;
            _userContext = userContext;
            _sessionContext = sessionContext;
        }

        

          public IQueryable SearchDownloadsByUserID(int userID)
        {
            //IQueryable<UserSession> sessions = from ses in _sessionContext.UserSessions
                 //  where ses.userID == userID
                  // select ses;

            /*List<UserSession> q1 = _sessionContext.UserSessions.Where(ses => ses.userID == userID).ToList();
            int i =0;
            IQueryable<Downloads> q2;
            for(i = 0; i < q1.Count; i++){
                q2.Prepend(_context.Downloads.Where(dn => dn.sessionID == q1[i].uid));
            }*/

        var obj = 
            from ses in _sessionContext.UserSessions
            join usr in _userContext.Users
            on ses.userID equals userID
            join dwn in _context.Downloads
            on ses.uid equals dwn.sessionID
            select new
            {
                usr.uid,
                usr.userName,
                dwn.downloadSize,
                dwn.trajectoryID
            };
            
            return obj;
      
        }

    }
}