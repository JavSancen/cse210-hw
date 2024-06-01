using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("Laptop", "P001", 1000m, 1);
        Product product2 = new Product("Mouse", "P002", 25m, 2);
        Product product3 = new Product("Keyboard", "P003", 75m, 1);

        Order order = new Order(customer1);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
    }
}