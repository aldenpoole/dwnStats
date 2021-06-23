//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace dwnStats.Data
{
    public class FilterContext : DbContext
    {
        public FilterContext(DbContextOptions<FilterContext> opt) : base(opt)
        {   
        }
        public DbSet <Filter> Filters { get; set; }
    }
}