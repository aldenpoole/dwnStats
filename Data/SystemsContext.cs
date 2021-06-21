//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace dwnStats.Data
{
    public class SystemsContext : DbContext
    {
            public SystemsContext(DbContextOptions<SystemsContext> opt) : base(opt)
            {
                
            }

            public DbSet <Systems> Systems { get; set; }
    }
}