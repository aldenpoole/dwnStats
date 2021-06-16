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
    }
}