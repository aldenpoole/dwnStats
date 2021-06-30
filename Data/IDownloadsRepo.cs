//Alden Poole
//Parsons Intern Project 2021

using System;
using System.Collections.Generic;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface IDownloadsRepo
    {
        bool SaveChanges();
        IEnumerable<Downloads> GetAllDownloads();
        Downloads GetDownloadsById(int uid);
        IEnumerable<Downloads> SearchBySessionID(int sessionID);
        IEnumerable<Downloads> SearchByDateTime(DateTime dateTime);
        IEnumerable<Downloads> SearchByDateHour(int yyyy, int mm, int dd, int hh);
    }
}