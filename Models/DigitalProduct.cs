namespace InstantMart.Models
{
    // SESSION 4: Inheritance
    // TODO: Inherit from Product
    public class DigitalProduct
    {
        // Property for DownloadLink
        public string DownloadLink { get; set; } = string.Empty;

        // TODO: Constructor with : base() call
        // Parameters: name, price, stock, link

        // TODO: Override CalculatePrice()
        // Apply 10% discount: Price * 0.9m
    }
}
