using System;

public class Product
{
    // member variables
    private string _name;
    private int _productID, _quantity;
    private double _price;
    // constructor
    public Product (string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // get the total price
    public double GetTotalPrice ()
    {
        double totalPrice = _price * _quantity;
        return totalPrice;
    }

    // getter for the product name
    public string GetName ()
    {
        return _name;
    }

    // getter for the product ID
    public int GetProductID ()
    {
        return _productID;
    }
}