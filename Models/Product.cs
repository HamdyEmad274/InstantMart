namespace InstantMart.Models
{
    // SESSION 2 & 3: Base Class with Encapsulation
    public class Product
    {
        // TODO: Add properties with proper access modifiers
        // Name: public get, private set
        // Price: public get, protected set (for inheritance)
        // Stock: public get/set
        
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // SESSION 2: Static member
        // TODO: Add static TotalProductsCreated counter

        // SESSION 2: Constructor
        // TODO: Add constructor with validation:
        // - Name cannot be null/empty
        // - Price cannot be negative
        // - Increment TotalProductsCreated

        // SESSION 4: Virtual method for polymorphism
        // TODO: Add virtual CalculatePrice() method
        // Default: return Price

        // SESSION 2: Static method
        // TODO: Add DisplayStoreStats() static method
    }
}
