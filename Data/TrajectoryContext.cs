//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace dwnStats.Data
{
    public class TrajectoryContext : DbContext
    {
        public TrajectoryContext(DbContextOptions<TrajectoryContext> opt) : base(opt)
        { 
        }
        public DbSet <Trajectory> Trajectories { get; set; }
    }
}