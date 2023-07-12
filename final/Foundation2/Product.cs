public class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string productName, string productId, decimal price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculates the total price of the product based on price and quantity
    public decimal CalculateTotalPrice()
    {
        return _price * _quantity;
    }

    // Getter and setter for the product name
    public string ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }

    // Getter and setter for the product ID
    public string ProductId
    {
        get { return _productId; }
        set { _productId = value; }
    }

    // Getter and setter for the price
    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }

    // Getter and setter for the quantity
    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }
}
