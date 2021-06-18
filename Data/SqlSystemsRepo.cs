//Alden Poole
//Parsons Intern Project 2021

using dwnStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dwnStats.Data
{
    public class SqlSystemsRepo : ISystemsRepo
    {
        private readonly SystemsContext _context;

        public SqlSystemsRepo(SystemsContext context)
        {
            _context = context;
        }

        public IEnumerable<Systems> GetAllSystems()
        {
            return _context.Systems.ToList();
        }

        public Systems GetSystemsById(int id)
        {
           return _context.Systems.FirstOrDefault(p => p.uid == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}