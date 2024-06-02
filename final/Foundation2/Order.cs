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
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }


        if (_customer.LivesInUSA())
        {
            total += 5.00;
        }

        else
        {
            total += 35.00;
        }

        return total;

    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Packing label for {_customer.GetCustomerName()}:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"-Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping label for:\n{_customer.GetAddress()}";
    }
}