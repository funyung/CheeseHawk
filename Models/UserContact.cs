using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheeseHawk.Models
{
    public class UserContact
    {
		[Key]
		public string ContactId { get; set; }
		public string UserName { get; set; }
		public string PhoneNumber { get; set; }
		public decimal Amount { get; set; }
	}
}
