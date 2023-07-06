using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Calculate the total price of the order
    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.CalculateTotalPrice();
        }

        // Add shipping cost based on the customer's location
        if (customer.IsInUSA())
        {
            totalPrice += 5; // $5 shipping cost for USA
        }
        else
        {
            totalPrice += 35; // $35 shipping cost for non-USA
        }

        return totalPrice;
    }

    // Generate a packing label with product name and id for each product
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"Product: {product.ProductName}, ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    // Generate a shipping label with customer name and address
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer Name: {customer.Name}\n";
        shippingLabel += $"Address:\n{customer.GetFullAddress()}\n";
        return shippingLabel;
    }
}
