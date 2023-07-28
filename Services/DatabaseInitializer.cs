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

                UserContact firstuser = new UserContact()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "funkydude01",
                    PhoneNumber = "4206969"
                };

				UserContact seconduser = new UserContact()
				{
					Id = Guid.NewGuid().ToString(),
					UserName = "funkydude02",
					PhoneNumber = "00000000"
				};

				UserContact thirdduser = new UserContact()
				{
					Id = Guid.NewGuid().ToString(),
					UserName = "funkydude03",
					PhoneNumber = "00009999"
				};

				_context.Database.EnsureCreated();

				_context.Add(firstuser);
                _context.Add(seconduser);
                _context.Add(thirdduser);

                _context.SaveChanges();
            }
        }
    }
}
