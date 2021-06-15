using dwnStats.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace dwnStats.Data
{
    public class UserContext : DbContext
    {
            public UserContext(DbContextOptions<UserContext> opt) : base(opt)
            {
                
            }

            public DbSet <User> Users { get; set; }
    }
}