public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Check if the customer's address is in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    internal object GetFullAddress()
    {
        throw new NotImplementedException();
    }

    // Getter for private variable
    public string Name { get { return name; } }
}
