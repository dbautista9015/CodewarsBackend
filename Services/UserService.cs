using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Services.Context;

namespace CodewarsBackend.Services
{
    public class UserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context=context;
        }
    }
}