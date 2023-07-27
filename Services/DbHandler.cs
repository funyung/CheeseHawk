using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseHawk.Services
{
    class DbHandler
    {
        private readonly CheeseHawkContext _context;

        public DbHandler(CheeseHawkContext context)
        {
            _context = context;
        }
    }
}
