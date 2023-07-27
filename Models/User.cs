using System.ComponentModel.DataAnnotations;

namespace CheeseHawk.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
		public string UserName { get; set; }
		public int PhoneNumber { get; set; }

        public User() {}

        public User( int id, string userName, int phoneNumber )
        {
            Id = id;
            UserName = userName;
            PhoneNumber = phoneNumber;
        }

		public List<Contact>    Contacts;
    }
}
