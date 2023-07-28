﻿using System.ComponentModel.DataAnnotations;

namespace CheeseHawk.Models
{
    public class PaymentRequest : BaseModel
    {
        public decimal Amount { get; set; }
        public string Reason { get; set; }
    }
}
