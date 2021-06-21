//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dwnStats.Data
{
    public class SqlTrajectoryRepo : ITrajectoryRepo
    {
        private readonly TrajectoryContext _context;

        public SqlTrajectoryRepo(TrajectoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Trajectory> GetAllTrajectories()
        {
            return _context.Trajectories.ToList();
        }

        public Trajectory GetTrajectoriesById(int id)
        {
           return _context.Trajectories.FirstOrDefault(p => p.uid == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}