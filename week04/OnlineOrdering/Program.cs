using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Road 34 street 45.", "Cartagena", "Bolivar", "Colombia");
        Address address2 = new Address("Road 45 street 20.", "Riobamba", "Chimborazo", "Ecuador");
        Address address3 = new Address("Road 25 street 13.", "Logan", "Utah", "Usa");

        Customer customer1 = new Customer("Karla Morris", address1);
        Customer customer2 = new Customer("Brigham Mcallister", address2);
        Customer customer3 = new Customer("Joseph Grove", address3);

        List<Product> cart1 = new List<Product>();
        List<Product> cart2 = new List<Product>();
        List<Product> cart3 = new List<Product>();

        Order order1 = new Order(customer1, cart1);
        Order order2 = new Order(customer2, cart2);
        Order order3 = new Order(customer3, cart3);

        order1.AddProduct(new Product("Desktop", "45E", 500, 2));
        order1.AddProduct(new Product("Television", "56F", 400, 3));
        

        order2.AddProduct(new Product("Shirt", "36h", 5, 7));
        order2.AddProduct(new Product("Shoes", "23k", 10, 2));
        
        
        order3.AddProduct(new Product("Cell phone", "36h", 200, 7));
        order3.AddProduct(new Product("Earphones", "23k", 40, 2));
        
        Console.WriteLine("\noOrder");

        double total1 = order1.OrderTotal();
        Console.WriteLine("\n#Order 1 \n");
        Console.WriteLine($"Total: ${total1}");
        order1.PackingLabel();
        order1.ShippingLabel();

        double total2 = order2.OrderTotal();
        Console.WriteLine("\n#Order 2\n");
        Console.WriteLine($"Total: ${total2}");
        order2.PackingLabel();
        order2.ShippingLabel();        
             
        double total3 = order3.OrderTotal();
        Console.WriteLine("\n#Order 3\n");
        Console.WriteLine($"Total: ${total3}");
        order3.PackingLabel();
        order3.ShippingLabel();    

    }
}