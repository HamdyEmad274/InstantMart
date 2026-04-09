namespace InstantMart.Models
{
    // SESSION 4: Inheritance
    // TODO: Inherit from Product
    public class DigitalProduct : Product
    {
        public string DownloadLink { get; set; } = string.Empty;
        public DigitalProduct(string name, decimal price, int stock , string downloadLink) : base(name, price, stock)
        {
            DownloadLink = downloadLink;
        }
        public override decimal CalculatePrice()
        {
            return Price * 0.9m; // 10% discount for digital products
        }
    }
}
