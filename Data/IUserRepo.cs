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
        IEnumerable<User> SearchUser(string userName);
        IEnumerable<User> SearchFirst(string firstName);
        IEnumerable<User> SearchFullName(string firstName, string lastName);
    }
}