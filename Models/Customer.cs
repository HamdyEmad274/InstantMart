namespace InstantMart.Models
{
    // SESSION 2: Basic Class
    public class Customer
    {
        // Properties
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Constructor
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
