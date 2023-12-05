using System;

class Program
{
    static void Main(string[] args)
    {
        // create 2 orders with 3 products each
        // create addresses
        Address address1 = new Address("555 Evening Crest Dr.", "Herriman", "UT", "United States");
        Address address2 = new Address("555 Charisma Ln.", "Panama City", "Panama", "Panama");

        // create customers
        Customer customer1 = new Customer("Willy Keel", address1);
        Customer customer2 = new Customer("Michael Carmichael", address2);

        // create products
        Product sausage = new Product("sausage", 19854, 6.98, 4);
        Product eggs = new Product("eggs", 19855, 3.49, 1);
        Product movie = new Product("movie", 19856, 20.21, 1);
        Product milk = new Product("milk", 19857, 2.19, 2);
        Product cheese = new Product("cheese", 19858, 12.90, 3);
        Product spoons = new Product("spoons", 19859, 49.99, 1);

        // create the orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // add products to the orders
        order1.AddProduct(sausage);
        order1.AddProduct(eggs);
        order1.AddProduct(movie);
        
        order2.AddProduct(milk);
        order2.AddProduct(cheese);
        order2.AddProduct(spoons);

        // order1
        // Call the methods to get the packing label and display
        Console.WriteLine("Packing Label:");
        Console.WriteLine($"{order1.GetPackingLabel()}");

        // Get the shipping label and display
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{order1.GetShippingLabel()}");

        // Get the total price of the orders and display
        Console.WriteLine("Order Total:");
        Console.WriteLine($"{order1.GetTotalPrice()}");
        Console.WriteLine($"");

        // order2
        Console.WriteLine("Packing Label:");
        Console.WriteLine($"{order2.GetPackingLabel()}");

        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{order2.GetShippingLabel()}");

        Console.WriteLine("Order Total:");
        Console.WriteLine($"${order2.GetTotalPrice()}");
        Console.WriteLine($"");
    }
}