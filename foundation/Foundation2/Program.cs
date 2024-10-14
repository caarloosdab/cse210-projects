using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple Street", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm Street", "Toronto", "Ontario", "Canada");

        // Create Customer objects
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Product objects for first order
        Product product1 = new Product("Laptop", "L123", 800.00m, 1);
        Product product2 = new Product("Mouse", "M456", 20.00m, 2);

        // Create Product objects for second order
        Product product3 = new Product("Tablet", "T789", 300.00m, 1);
        Product product4 = new Product("Charger", "C012", 15.00m, 3);

        // Create Order objects and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display information for first order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        // Display information for second order
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}