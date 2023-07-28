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

            _context.Records.Add(newuser);
            await _context.SaveChangesAsync();
		}

		UserContact GetContactByID(string id)
		{
			return _context.Records.OfType<UserContact>().SingleOrDefault(x => x.Id == id);
		}
        public List<UserContact> GetAllContacts() 
        {
            return _context.Records.OfType<UserContact>().ToList();
        }
		public void RemoveUserContact(string userId)
        {
            _context.Remove(GetContactByID(userId));
            _context.SaveChanges();
        }

		public async Task AddPaymentRequest(string requestorName, decimal amount, string reason)
		{
            var req = _context.Records.FromSql
                ($"SELECT iD FROM UserContact WHERE UserName={requestorName}");

            PaymentRequest newRequest = new PaymentRequest()
            {
                Id = requestorName,
                Amount = amount,
                Reason = reason
            };

            _context.Records.Add(newRequest);
            await _context.SaveChangesAsync();
		}

        public decimal GetContactsTotalTab(string contactId)
        {
            var req = _context.Records.OfType<PaymentRequest>().ToList();

            decimal total = 0;
            foreach ( var payment in req )
            {
                if(payment.Id == contactId)
                total += payment.Amount;
            }
            return total;
        }

        public void GetOldestContact()
        {
		    var lastDbContact = _context.Records.FromSql
                ($"SELECT * FROM Users ORDER BY iD DESC LIMIT 1").Single();

            Console.WriteLine(lastDbContact + " is your oldest contact!\n");
        }
	}
}
