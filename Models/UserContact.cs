using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseHawk.Models
{
    public class UserContact
    {
		public UserContact( string name, int phone )
		{
			Name = name;
			PhoneNumber = phone;
		}

		public string	Name { get; set; }
		public int		PhoneNumber { get; set; }

		public bool		IsPaymentRequested() 
		{
			if(RequestedPayments.Count > 0)
			{
				return true;
			}

			return false;
		}

		public List<PaymentRequest> RequestedPayments;

		public void RequestPayment(PaymentRequest paymentRequest)
		{
			RequestedPayments.Add(paymentRequest);
		}

		public decimal Balance()
		{
			decimal total = 0;
			foreach(var p in RequestedPayments)
			{
				total += p.Amount;
			}
			return total;
		}
	}
}
