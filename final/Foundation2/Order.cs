using System;

public class Order
{
    // member variables
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private double _orderTotal;
    private string _packingLabel;
    private string _shippingLabel;

    // constructor
    public Order (Customer customer)
    {
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            subtotal += product.GetTotalPrice();
        }

        if (_customer.LivesInUSA())
        {
            _orderTotal = subtotal + 5;
        }

        else
        {
            _orderTotal = subtotal + 35;
        }

        return _orderTotal;
    }

    // getter for packing label
    public string GetPackingLabel()
    {
        _packingLabel = $"";
        foreach (Product product in _products)
        {
            string productName = product.GetName();
            int productID = product.GetProductID();
            _packingLabel += $"{productName} -- {productID}\n";
        }

        return _packingLabel;
    }

    // getter for shipping label
    public string GetShippingLabel()
    {
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress();
        _shippingLabel = $"{customerName}\n{customerAddress}";
        return _shippingLabel;
    }

    // add products to the list 
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}