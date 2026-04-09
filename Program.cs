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
            Console.WriteLine("=== BETTING GAME #1: Memory Test ===");
            // TODO: Demonstrate Money struct vs Product class behavior
            
            Money wallet = new Money(100.00m);
            Console.WriteLine($"Before: {wallet.Amount}");
            // TODO: Create TryModifyMoney method call here
            Console.WriteLine($"After: {wallet.Amount}");
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
    }
}
