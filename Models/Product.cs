namespace InstantMart.Models
{
    // SESSION 2 & 3: Base Class with Encapsulation
    public class Product
    {
        // TODO: Add properties with proper access modifiers
        // Name: public get, private set
        // Price: public get, protected set (for inheritance)
        // Stock: public get/set

        public string Name { get; private set; } = string.Empty;
        public decimal Price { get; protected set; }
        public int Stock { get; set; }

        // SESSION 2: Static member
        // TODO: Add static TotalProductsCreated counter
        public static int TotalProductsCreated { get; private set; }

        // SESSION 2: Constructor
        // TODO: Add constructor with validation:
        // - Name cannot be null/empty
        // - Price cannot be negative
        // - Increment TotalProductsCreated

        public Product(string name, decimal price, int stock)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.");
            if (price < 0)
                throw new ArgumentException("Price cannot be negative.");

            Name = name;
            Price = price;
            Stock = stock;

            TotalProductsCreated++;
        }

        // SESSION 4: Virtual method for polymorphism
        // TODO: Add virtual CalculatePrice() method
        // Default: return Price
        public virtual decimal CalculatePrice()
        {
            return Price;
        }

        // SESSION 2: Static method
        // TODO: Add DisplayStoreStats() static method
        public static void DisplayStoreStats()
        {
            Console.WriteLine($"Total products created: {TotalProductsCreated}");
        }
    }
    public class PhysicalProduct : Product
    {
        public double WeightKg { get; set; }
        public PhysicalProduct(string name , decimal price , int stock , double wight) : base(name , price ,stock)
        {
            WeightKg = wight;
        }

        public override decimal CalculatePrice()  // Override is type of Polymorphism
        {
            // conditional expression way to write : condition ? trueValue : falseValue;
            decimal shippingCost = WeightKg > 1 ? 10m : 5m;
            return Price + shippingCost;
        }

    }

}
