using InstantMart.Models;
using InstantMart.Services;

namespace InstantMart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║      INSTANTMART CHECKOUT          ║");
            Console.WriteLine("╚════════════════════════════════════╝\n");

            // ===== SEGMENT 1: Memory & Foundation Demo =====
            // BETTING GAME #1: Struct vs Class

            // Stack Vs Heap
            // Stack has Value Types and local variables and refernces to heap objects , Heap has objects

            Console.WriteLine("=== BETTING GAME #1: Memory Test ===");
            // TODO: Demonstrate Money struct vs Product class behavior
            
            Money wallet = new Money(100.00m);
            //Product product = new Product{Name = "Product", Price = 100.00m};
            Product product = new Product("Product", 100.00m, 10);
            Product product2 = new Product("Product", 100.00m, 10);
            Product product3 = new Product("Product", 100.00m, 10);
            Console.WriteLine($"Before: {wallet.Amount}");
            //Console.WriteLine($"Before: {product.Price}");
            // TODO: Create TryModifyMoney method call here
            TryModifyMoney(wallet);
            //TryModifyMoney(product);
            Console.WriteLine($"After: {wallet.Amount}");
            //Console.WriteLine($"After: {product.Price}");
            Console.WriteLine();

            // ===== SEGMENT 2: Inheritance & Polymorphism Demo =====
            // BETTING GAME #2: Polymorphism Test
            Console.WriteLine("=== BETTING GAME #2: Polymorphism Test ===");
            // TODO: Create List<Product> with different product types
            // TODO: Loop and call CalculatePrice() — which one runs?
            Console.WriteLine();

            // ===== SEGMENT 3: Interface Demo =====
            // BETTING GAME #3: Interface Trap
            Console.WriteLine("=== BETTING GAME #3: Interface Trap ===");
            // Question: Can you do IPaymentProcessor p = new IPaymentProcessor(); ?
            // TODO: Create payment processors and demonstrate interface usage
            Console.WriteLine();

            // ===== SEGMENT 4: Generics Demo =====
            Console.WriteLine("=== GENERICS DEMO ===");
            // TODO: Create Repository<Product> and Repository<Customer>
            // TODO: Add items and display counts
            Console.WriteLine();

            // ===== FINAL INTEGRATION =====
            Console.WriteLine("=== COMPLETE INSTANTMART DEMO ===");
            // TODO: Grand finale — put it all together

            // Static stats
            Product.DisplayStoreStats();
        }

        // TODO: Add TryModifyMoney method here for Betting Game #1
        public static void TryModifyMoney(Money money)
        {
            money = new Money(999.99m);
            Console.WriteLine($"Inside the Method {money.Amount}");
        }
        //public static void TryModifyMoney(Product money)
        //{
        //    //money.Price = 999.99m;
        //    Console.WriteLine($"Inside the Method {money.Name}");
        //}
    }
}
