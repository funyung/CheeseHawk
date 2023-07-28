using System.ComponentModel.DataAnnotations;

namespace CheeseHawk.Models
{
    public class UserContact : BaseModel
    {
		public string UserName { get; set; }
		public string PhoneNumber { get; set; }
	}
}
