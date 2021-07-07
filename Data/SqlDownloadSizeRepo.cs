//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dwnStats.Data
{
        public class SqlDownloadSizeRepo : IDownloadsSizeRepo
        {
            private readonly DownloadsContext _context;

            public SqlDownloadSizeRepo(DownloadsContext context)
            {
                _context = context;
            }
            public IEnumerable<DownloadSize> GetPastDaysDownloads()
            {
                var dwn = _context.Downloads.ToList();

                DateTime current = DateTime.Now;
                DateTime previous = current.AddDays(-1);

                Console.WriteLine(current);
                Console.WriteLine(previous);


                var pastDaysDownloads = from dr in dwn
                    where dr.downloadTime <= current
                    where dr.downloadTime >= previous
                    select new DownloadSize
                        {
                            downloadSize = dr.downloadSize,
                            time = dr.downloadTime
                        }; 
            
                return pastDaysDownloads;
            }
        }
}