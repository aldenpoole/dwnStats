//Alden Poole
//Parsons Intern Project 2021

using System.Collections.Generic;
using System.Threading.Tasks;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface IUserRepo
    {
        bool SaveChanges();

        IEnumerable<User> GetAllUsers();
        User GetUserById(int uid);
    
        void DeleteUser(User usr);

        Task<IEnumerable<User>> Search(string userName);
    }
}