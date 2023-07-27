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
