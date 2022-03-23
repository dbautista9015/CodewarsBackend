using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Models;
using CodewarsBackend.Services.Context;

namespace CodewarsBackend.Services
{
    public class CompletedService
    {
        private readonly DataContext _context;
        public CompletedService(DataContext context)
        {
            _context = context;
        }

        public bool AddCompletedKata(CompletedModel newCompletedModel)
        {
             _context.Add(newCompletedModel);
            return _context.SaveChanges() != 0;
        }

        public IEnumerable<CompletedModel> GetAllCompletedKatas()
        {
            return _context.CompletedInfo;        
        }

        public IEnumerable<CompletedModel> GetCompletedKatasByCohortId(int cohortId)
        {
            return _context.CompletedInfo.Where(item => item.CohortId == cohortId);
        }

        public IEnumerable<CompletedModel> GetCompletedKatasByCodewarsName(string codewarsName)
        {
            return _context.CompletedInfo.Where(item => item.CodewarsName == codewarsName);
        }

    }
}