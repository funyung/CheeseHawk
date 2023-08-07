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
				ContactId = newId,
				UserName = username,
				PhoneNumber = phonenumber
			};

            _context.UserContacts.Add(newuser);
            await _context.SaveChangesAsync();
		}

		UserContact GetContactByID(string id)
		{
			return _context.UserContacts.SingleOrDefault(x => x.ContactId == id);
		}

		UserContact GetContactByName(string name)
		{
			return _context.UserContacts.SingleOrDefault(x => x.UserName == name);
		}

		public List<UserContact> GetAllContacts() 
        {
            return _context.UserContacts.ToList();
        }
		public void RemoveUserContact(string userId)
        {
            _context.Remove(GetContactByID(userId));
            _context.SaveChanges();
        }

		public async Task AddPaymentRequest(string requestorName, decimal amount)
		{
            var req = GetContactByName(requestorName);

            req.Amount += amount;
            
            _context.UserContacts.Update(req);
            await _context.SaveChangesAsync();
		}

        public decimal GetContactsTotalTab(string contactId)
        {
            var req = _context.UserContacts.ToList();

            decimal total = 0;
            foreach ( var payment in req )
            {
                if (payment.ContactId == contactId)
                    total = payment.Amount;
            }

            return total;
        }

        public void GetOldestContact()
        {
		    var lastDbContact = _context.UserContacts.FromSql
                ($"SELECT * FROM UserContacts ORDER BY ContactId DESC LIMIT 1").Single();

            Console.WriteLine(lastDbContact + " is your oldest contact!\n");
        }
	}
}
