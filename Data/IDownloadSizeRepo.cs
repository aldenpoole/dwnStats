//Alden Poole
//Parsons Intern Project 2021

using System;
using System.Collections.Generic;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface IDownloadsSizeRepo
    {
        IEnumerable<DownloadSize> GetPastDaysDownloads();
    }
}