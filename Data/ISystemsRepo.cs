//Alden Poole
//Parsons Intern Project 2021

using System.Collections.Generic;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface ISystemsRepo
    {
        bool SaveChanges();
        IEnumerable<Systems> GetAllSystems();
        Systems GetSystemsById(int uid);
    }
}