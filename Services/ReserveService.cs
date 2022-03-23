using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Services.Context;

namespace CodewarsBackend.Services
{
    public class ReserveService
    {
        private readonly DataContext _context;

        public ReserveService(DataContext context)
        {
            _context=context;
        }
    }
}