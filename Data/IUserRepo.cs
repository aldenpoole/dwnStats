//Alden Poole
//Parsons Intern Project 2021

using System.Collections.Generic;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface IUserRepo
    {
        bool SaveChanges();

        IEnumerable<User> GetAllUsers();
        User GetUserById(int uid);
        void CreateUser(User usr);
        void UpdateUser(User usr);
        void DeleteUser(User usr);
    }
}