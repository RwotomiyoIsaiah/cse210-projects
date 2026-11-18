using System;
class Program
{
    static void Main(string[] args)
    {
        //custom created orders for this test
        // customer 1
        Address address1 = new Address("1234 Main Street","New York","NY","USA");
        Customer customer1 = new Customer("Taremwa Joel",address1);
        //  order 1
        Order order1 = new Order(customer1);
        Product product1 = new Product("Laptop","P001",800,1);
        Product product2 = new Product("Mouse","P002",25,2);
        Product product3 = new Product("Keyboard","P003",45,1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        //  customer 2
        Address address2 = new Address("67 Kampala Road","Kampala","Central","Uganda");
        Customer customer2 = new Customer("Rwotomiyo Isaiah",address2);
        // order 2
        Order order2 = new Order(customer2);
        Product product4 = new Product("Phone","P004",500,1);
        Product product5 = new Product("Phone Case","P005",20,2);
        Product product6 = new Product("Charger","P006",30,1);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Display first order
        Console.WriteLine("FIRST ORDER");
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        // Display second order
        Console.WriteLine("SECOND ORDER");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
        Console.WriteLine();
        double OTotal= order2.GetTotalPrice() + order1.GetTotalPrice();
        Console.WriteLine($"OVERALL TOTAL: ${OTotal:F2}");
    }
}