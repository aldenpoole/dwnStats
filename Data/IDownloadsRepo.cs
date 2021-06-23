//Alden Poole
//Parsons Intern Project 2021

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
    }
}