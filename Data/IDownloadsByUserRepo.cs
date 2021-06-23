//Alden Poole
//Parsons Intern Project 2021

using System.Collections.Generic;
using System.Linq;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface IDownloadsByUserRepo
    {
        IEnumerable<DownloadByUser> SearchDownloadsByUserID(int userID); 
    }
}