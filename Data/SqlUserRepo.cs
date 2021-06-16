using dwnStats.Models;
using System.Collections.Generic;
using System.Linq;

namespace dwnStats.Data
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly UserContext _context;

        public SqlUserRepo(UserContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
           return _context.Users.FirstOrDefault(p => p.uid == id);
        }

        
    }
}