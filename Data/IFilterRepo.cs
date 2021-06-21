//Alden Poole
//Parsons Intern Project 2021

using System.Collections.Generic;
using dwnStats.Models;

namespace dwnStats.Data
{
    public interface IFilterRepo
    {
        
        bool SaveChanges();
        IEnumerable<Filter> GetAllFilters();
        Filter GetFiltersById(int uid);
    }
}