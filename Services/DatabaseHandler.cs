using CheeseHawk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseHawk.Services
{
    public class DatabaseHandler
    {
		private readonly CheeseHawkContext _context;

        public DatabaseHandler(CheeseHawkContext context)
        { 
            _context = context;
		}

        public async Task AddContact( string username, string phonenumber )
        {
            string newId = Guid.NewGuid().ToString();

			UserContact newuser = new UserContact()
			{
				Id = newId,
				UserName = username,
				PhoneNumber = phonenumber
			};

            _context.Users.Add(newuser);
            await _context.SaveChangesAsync();
		}

		UserContact GetContactByID(string id)
		{
			return _context.Users.SingleOrDefault(x => x.Id == id);
		}
		public void RemoveUserContact(string userId)
        {
            _context.Remove(GetContactByID(userId));
            _context.SaveChanges();
        }

		public async Task AddPaymentRequest(string requestorName, decimal amount, string reason)
		{
            var req = _context.Users.FromSql
                ($"SELECT iD FROM Users WHERE UserName={requestorName}");

            PaymentRequest newRequest = new PaymentRequest()
            {
                ContactId = requestorName,
                Amount = amount,
                Reason = reason
            };

            _context.PaymentRequests.Add(newRequest);
            await _context.SaveChangesAsync();
		}

        public decimal TotalContactsTab(string contactId)
        {
            var req = _context.PaymentRequests
                .FromSql($"SELECT Amount FROM PaymentRequests WHERE ContactId={contactId}")
                .ToList();
            decimal total = 0;
            foreach ( var contact in req )
            {
                total += contact.Amount;
            }
            return total;
        }

        public void GetOldestContact()
        {
		    var lastDbContact = _context.Users.FromSql
                ($"SELECT * FROM Users ORDER BY iD DESC LIMIT 1").Single();

            Console.WriteLine(lastDbContact + " is your oldest contact!\n");
        }
	}
}
