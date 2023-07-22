using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseHawk.Models
{
    public class PaymentRequest
    {
        public decimal Amount { get; set; }
        public string Reason { get; set; }
    }
}
