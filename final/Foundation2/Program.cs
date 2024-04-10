using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Maple Street 42", "Springfield", "Springfield", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);
        List<Product> productsList1 = new List<Product>();
        Product p1001 = new Product("Duff Beer", "DB001", 4.99, 6);
        Product p1002 = new Product("Donut", "DN100", 2.50, 12);
        Product p1003 = new Product("Squishee", "SQ202", 1.99, 8);
        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);
        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 788");
        order1.DisplayResults();
        Console.WriteLine();


        Address address2 = new Address("123 Random St", "Whimsyville", "XY 12345", "Fantasia");
        Customer customer2 = new Customer("Quirk A. Quark", address2);
        List<Product> productsList2 = new List<Product>();
        Product p2001 = new Product("Glowing Orb Set", "GOSET", 19.99, 2);
        Product p2002 = new Product("Dreamy Clouds", "DC200", 8.25, 5);
        Product p2003 = new Product("Enchanted Wand", "ENW100", 35.00, 1);
        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);
        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 5678");
        order2.DisplayResults();
        Console.WriteLine();


        Address address3 = new Address("1234 Random St", "Randomville", "XY 56789", "Randomland");
        Customer customer3 = new Customer("Jane Doe", address3);
        List<Product> productsList3 = new List<Product>();
        Product p3001 = new Product("Widget", "WIDG001", 12.49, 3);
        Product p3002 = new Product("Gizmo", "GZM001", 7.99, 5);
        productsList3.Add(p3001);
        productsList3.Add(p3002);
        Order order3 = new Order(productsList3, customer3);
        
        Console.WriteLine("Order Number: 879789");
        order3.DisplayResults();
        Console.WriteLine();
    }
}
