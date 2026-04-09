namespace InstantMart.Models
{
    // SESSION 1: Value Type (struct)
    // TODO: Define this as a struct
    public struct Money
    {
        // Property for Amount
        public decimal Amount { get; set; }
        // Constructor
        public Money(decimal amount)
        {
            Amount = amount;
        }
    }
    public class MoneyC
    {
        // Property for Amount
        public decimal Amount { get; set; }

        // TODO: Add constructor
        // public Money(decimal amount) { ... }
    }
}
