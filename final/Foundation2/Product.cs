using System;
using System.Collections.Generic;


class Product
{
    private string productName;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string productName, string productId, decimal price, int quantity)
    {
        this.productName = productName;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }


    public decimal CalculateTotalPrice()
    {
        return price * quantity;
    }

    // Write the getter and setter for the private variables
    public string Name
    {
        get
        {
            return Name;
        }
        set
        {
            Name = value;
        }
    } 

    public string ProductId
    {
        get 
        {
            return ProductId;
        }
        set
        {
            ProductId = value;
        }
    }


    public decimal Price 
    {
        get
        {
            return Price;
        }
        set
        {
            Price =value;
        }
    }


    public int Quantity 
    {
        get
        {
            return Quantity;
        }
        set
        {
            Quantity = value;
        }
    }

    public object ProductName { get; internal set; }
}
