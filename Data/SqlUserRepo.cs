//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dwnStats.Data
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly UserContext _context;

        public SqlUserRepo(UserContext context)
        {
            _context = context;
        }

   

        public void DeleteUser(User usr)
        {
            if(usr == null){
                throw new ArgumentNullException(nameof(usr));
            }
            _context.Users.Remove(usr);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
           return _context.Users.FirstOrDefault(p => p.uid == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public async Task<IEnumerable<User>> Search(string userName)
        {
        IQueryable<User> query = _context.Users;
            
        if (userName !=null)
        {
            query = query.Where(e => e.userName.Contains(userName)
                        || e.userName.Contains(userName));
        }

       

        return await query.ToListAsync();
        }

    }
}