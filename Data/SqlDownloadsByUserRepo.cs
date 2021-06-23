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
            var ses = _sessionContext.UserSessions.ToList();
            var usr = _userContext.Users.ToList();
            var dwn = _context.Downloads.ToList();

            var obj =  
                from session in ses
                where userID == session.userID
                join user in usr
                on userID equals user.uid
                join down in dwn
                on session.uid equals down.sessionID
                select new DownloadByUser
                    { 
                        downloadSize = down.downloadSize,
                        trajectoryID = down.trajectoryID,
                        downloadTime = down.downloadTime
                    };
            
            return obj;
        }
    }
}