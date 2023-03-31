using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public double CalculateTotalPrice()
    {
        double totalprice = 0;

        foreach (Product p in _products)
        {
            double price = p.CalculatePrice();
            totalprice += price;
        }
        double shippingCost = 0;
        if (_customer.isFromUSA() == true)
        {
            shippingCost = 5;
        } 
        else
        {
            shippingCost = 35;
        }

        totalprice += shippingCost;

        return totalprice;
    }
}
