using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseHawk.Models
{
    public class UserContact
    {
		public int ContactId { get; set; }
		public string	UserName { get; set; }
		public string	Email { get; set; }
		public string	PhoneNumber { get; set; }
		public decimal	Balance { get; set; }
		public bool		IsPaymentRequested { get; set; }

		public List<PaymentRequest> RequestedPayments;
	}
}
