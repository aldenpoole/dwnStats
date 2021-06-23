//Alden Poole
//Parsons Intern Project 2021

using System.Collections.Generic;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface ITrajectoryRepo
    {
        bool SaveChanges();
        IEnumerable<Trajectory> GetAllTrajectories();
        Trajectory GetTrajectoriesById(int uid);
    }
}