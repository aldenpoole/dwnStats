//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dwnStats.Data
{
    public class SqlDownloadsRepo : IDownloadsRepo
    {
        private readonly DownloadsContext _context;
        public SqlDownloadsRepo(DownloadsContext context)
        {
            _context = context;
        }
        public IEnumerable<Downloads> GetAllDownloads()
        {
            return _context.Downloads.ToList();
        }
        public Downloads GetDownloadsById(int id)
        {
           return _context.Downloads.FirstOrDefault(p => p.uid == id);
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
          public IEnumerable<Downloads> SearchBySessionID(int sessionID)
        {
            IEnumerable<Downloads> downloads = from tr in _context.Downloads
                   where tr.sessionID== sessionID
                   select tr;
            return downloads.ToList();
        }

    }
}