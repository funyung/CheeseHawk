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
		[Key]
		public int ContactId { get; set; }
		public string	Email { get; set; }
		[Required]
		public string	PhoneNumber { get; set; }
		public bool		IsPaymentRequested { get; set; }

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
