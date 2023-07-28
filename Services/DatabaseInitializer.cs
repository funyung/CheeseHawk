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
                    Id = Guid.NewGuid().ToString(),
                    UserName = "funkydude01",
                    PhoneNumber = "4206969"
                };

                PaymentRequest firstpayment = new PaymentRequest()
                {
                    Id = firstcontact.Id,
                    Amount = 20,
                    Reason = "He owes me..."
                };
                _context.Records.Add(firstcontact);
                _context.Records.Add(firstpayment);

                _context.SaveChanges();
            }
        }
    }
}
