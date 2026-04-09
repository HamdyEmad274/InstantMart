namespace InstantMart.Models
{
    // SESSION 4: Inheritance
    // TODO: Inherit from Product
    public class SubscriptionProduct : Product
    {
        // Property for BillingMonths
        public int BillingMonths { get; set; }

        // TODO: Constructor with : base() call
        // Parameters: name, price, stock, months
        public SubscriptionProduct(string name, decimal price, int stock, int billingMonths) : base(name, price, stock)
        {
            BillingMonths = billingMonths;
        }
        // TODO: Override CalculatePrice()
        // Calculate: Price * BillingMonths * 0.95m (5% discount)
        public override decimal CalculatePrice()
        {
            return Price * BillingMonths * 0.95m;
        }
    }
}
