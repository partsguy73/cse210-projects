using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");

        Product product1 = new Product("Baseball", 123, 5.19, 2);
        Product product2 = new Product("Softball", 223, 9.99, 3);
        Product product3 = new Product("Golf Ball", 323, 7.99, 4);

        Address address1 = new Address("111 Bagshot Row", "Hobbiton", "Shire", "Middle Earth");
        Address address2 = new Address("841 E Colony Circle", "Washington", "Utah", "USA");

        Customer customer1 = new Customer("Bilbo Baggins", address1);
        Customer customer2 = new Customer("John Scott", address2);

        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product2, product3 }, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine("\nOrder2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");

    }
}