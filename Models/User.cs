using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseHawk.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public int ContactId { get; set; }

        public List<UserContact>    Contacts;
    }
}
