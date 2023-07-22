using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseHawk.Models
{
    public class PaymentRequest
    {
        public int ContactIdTo { get; set; }
        public int ContactIdFrom { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
    }
}
