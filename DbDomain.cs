using DIS_Assignment4_Spring2021.DataAccess;
using DIS_Assignment4_Spring2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIS_Assignment4_Spring2021.Domain
{
    public class DbDomain
    {
        public ApplicationDbContext _context;

        public DbDomain(ApplicationDbContext context)
        {
            _context = context;
        }

        public void covidConditionPost(Covid_Conditions covid1)
        {
            _context.Covid_Conditions.Add(covid1);
            _context.SaveChanges();
        }
       
    }
}
