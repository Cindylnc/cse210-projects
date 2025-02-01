using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.\n");


        Address address1 = new Address("185 Mountain Highway", "Park City", "UT", "USA");
        Address address2 = new Address("489 Jumo Street", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Jackie Gomez", address1);
        Customer customer2 = new Customer("David Saviet", address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(new Product("Notebooks", 9990189, 14.99, 6));
        order1.AddProduct(new Product("Folders", 9090120, 7.49,20));

        order2.AddProduct(new Product("Desk", 999899, 389.99,2));
        order2.AddProduct(new Product("Lamp", 89978, 39.00,2));
        order2.AddProduct(new Product("Laptop", 99909, 799.99,1));

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order1.GetOrderTotal()}\n ");
        Console.WriteLine("================");

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order2.GetOrderTotal()}");
        Console.WriteLine("================");




    }
}