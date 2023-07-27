using CheeseHawk.Models;

namespace CheeseHawk.Services
{
    public class DatabaseInitializer
    {
        private readonly CheeseHawkContext _context;
        
        public DatabaseInitializer(CheeseHawkContext context)
        {
            _context = context;
        }

        public void InitializeDB()
        {
            if (!File.Exists(_context.DbLocation))
            {
                _context.Database.EnsureCreated();

                _context.Add(new User( 00, "Shlohmo", 4206969 ));

                _context.SaveChanges();
            }
        }
    }
}
