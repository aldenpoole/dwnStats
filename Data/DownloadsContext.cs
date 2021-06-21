//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace dwnStats.Data
{
    public class DownloadsContext : DbContext
    {
            public DownloadsContext(DbContextOptions<DownloadsContext> opt) : base(opt)
            {
                
            }

            public DbSet <Downloads> Downloads { get; set; }
    }
}