using System;

namespace Foundation2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create customers
            Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
            Customer customer1 = new Customer("John Smith", usaAddress);

            Address nonUsaAddress = new Address("45 Independence Street", "Benin City", "BC", "Nigeria");
            Customer customer2 = new Customer("Bright Agbons", nonUsaAddress);

            // Create products
            Product product1 = new Product("Laptop", "1234", 800, 2);
            Product product2 = new Product("Mouse", "5678", 25, 3);
            Product product3 = new Product("Keyboard", "9876", 50, 1);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Display packing label, shipping label, and total price for each order
            Console.WriteLine("Order 1 Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());

            Console.WriteLine("Order 1 Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());

            Console.WriteLine("Order 1 Total Price: $" + order1.GetTotalPrice());

            Console.WriteLine("\nOrder 2 Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());

            Console.WriteLine("Order 2 Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());

            Console.WriteLine("Order 2 Total Price: $" + order2.GetTotalPrice());
        }
    }
}
