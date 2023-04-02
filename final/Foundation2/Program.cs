using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();



        Address address1 = new Address("345 road", "Nowhereville","OR","USA");  // the main address for the code

        Customer customer1 = new Customer("Paul", address1);

// The line above is for the first customer
// The line below is for a list of products that are being sold.

        List<Product> productsList1 = new List<Product>();

        Product Pr1 = new Product("Coupling black", "This is a device that connects to items ", 20,1); //both of these lines are in product class
        Product Pr2 = new Product("Xbox controller","This is a xbox accessory", 60,1);
        

        productsList1.Add(Pr1);
        

        Order order1 = new Order(productsList1, customer1); // order class. 
        Order order2 = new Order(productsList1,customer1);

        order1.DisplayResults();



    }
}