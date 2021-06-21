//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dwnStats.Data
{
    public class SqlFilterRepo : IFilterRepo
    {
        private readonly FilterContext _context;

        public SqlFilterRepo(FilterContext context)
        {
            _context = context;
        }

        public IEnumerable<Filter> GetAllFilters()
        {
            return _context.Filters.ToList();
        }

        public Filter GetFiltersById(int id)
        {
           return _context.Filters.FirstOrDefault(p => p.uid == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}