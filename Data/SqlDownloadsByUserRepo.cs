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

        

          public IEnumerable<DownloadByUser> SearchDownloadsByUserID(int userID)
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
        
       // IQueryable<User> users = from sessions in _sessionContext.UserSessions.Where(p => p.uid == userID)
           // select new {sessions.userID};
        var ses = _sessionContext.UserSessions.ToList();
        var usr = _userContext.Users.ToList();
        var dwn = _context.Downloads.ToList();
        
        var obj =  
            from session in ses
            join user in usr
            on session.userID equals userID
            join down in dwn
            on session.uid equals down.sessionID
            select new DownloadByUser
            {
                downloads = down,
                users = user
            };
            
            return obj;
      
        }

    }
}