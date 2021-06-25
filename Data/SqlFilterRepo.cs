//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dwnStats.Data
{
    public class SqlFilterRepo : IFilterRepo
    {
        private readonly FilterContext _context;
        private readonly DownloadsContext _dwnContext;
        private readonly UserSessionContext _sessionContext;
        public SqlFilterRepo(FilterContext context, DownloadsContext dwnContext, UserSessionContext sessionContext)
        {
            _context = context;
            _dwnContext = dwnContext;
            _sessionContext = sessionContext;
        }
        public IEnumerable<Filter> GetAllFilters()
        {
            return _context.Filters.ToList();
        }
        public Filter GetFiltersById(int id)
        {
           return _context.Filters.FirstOrDefault(p => p.uid == id);
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<DownloadedFilters> SearchCountryName(string countryName)
        {
            var dwn = _dwnContext.Downloads.ToList();
            var ses = _sessionContext.UserSessions.ToList();
            var fils = _context.Filters.ToList();

            var obj =
                from sessions in ses
                join filters in fils
                on sessions.filterID equals filters.uid
                //where countryName == filters.launchCountry
                join down in dwn
                on sessions.uid equals down.sessionID
                select new DownloadedFilters
                    { 
                        launchCountry = filters.launchCountry,
                        downloadID = down.uid,
                        downloadTime = down.downloadTime,
                        userID = sessions.userID
                    };
            
            return obj;
       
        }
    }
}