using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

            // This address is not real come back and make up a new one. 
        Address address1 = new Address("Fake address for now");

            // This isnt a real customer fix later.
        Customer customer1 = new Customer("Fake customer", address1);

        List<Product> productsList = new List<Product>();


            // this product is fake as well. 
        Product Pr1 = new Product("Fake item");

        productList1.add(Pr1);

        Order order1 = new Order(productsList1, customer1);

        order1.DisplayResults();



    }
}