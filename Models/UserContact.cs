using System.ComponentModel.DataAnnotations;

namespace CheeseHawk.Models
{
    public class UserContact
    {
        [Key]
        public String Id { get; set; }
		public string UserName { get; set; }
		public string PhoneNumber { get; set; }

		public List<int> ContactIds;
	}
}
