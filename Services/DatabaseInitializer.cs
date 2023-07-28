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
            if (!File.Exists("./cheesehawk.db"))
            {
                _context.Database.EnsureCreated();

                UserContact firstcontact = new UserContact()
                {
                    ContactId = Guid.NewGuid().ToString(),
                    UserName = "funkydude01",
                    PhoneNumber = "4206969",
                    Amount = 0.0m
                };

                _context.UserContacts.Add(firstcontact);

                _context.SaveChanges();
            }
        }
    }
}
