using System.ComponentModel.DataAnnotations;

namespace CheeseHawk.Models
{
    public class PaymentRequest
    {
        [Key]
        public String ContactId { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
    }
}
