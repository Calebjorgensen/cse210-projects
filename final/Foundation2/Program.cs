using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Address address1 = new Address("345 road", "","","");

        Customer customer1 = new Customer("Paul", address1);

        List<Product> productsList1 = new List<Product>();

        Product Pr1 = new Product("Coupling black", "", 20,1);
        

        productsList1.Add(Pr1);
        

        Order order1 = new Order(productsList1, customer1);

        order1.DisplayResults();



    }
}