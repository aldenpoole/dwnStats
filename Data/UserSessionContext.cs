//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace dwnStats.Data
{
    public class UserSessionContext : DbContext
    {
        public UserSessionContext(DbContextOptions<UserSessionContext> opt) : base(opt)
        {    
        }
        public DbSet <UserSession> UserSessions { get; set; }
    }
}