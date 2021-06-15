using System.Collections.Generic;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface IUserRepo
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(string id);
    }
}