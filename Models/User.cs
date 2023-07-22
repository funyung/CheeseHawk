﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseHawk.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string   Name { get; set; }
        public string   Email { get; set; }
        public int      PhoneNumber { get; set; }

        public List<UserContact>    Contacts;
    }
}
