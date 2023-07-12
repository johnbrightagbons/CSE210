
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _stateCode;
    private string _country;


    public Address(string address,string street, string city, string state, string stateCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _stateCode = stateCode;
        _country = country;
    }

    public string V { get; }

    public string GetFullAddress()
    {
        // Generate full address message
        return $"{_street}, {_city}, {_state},{_stateCode} {_country}";
    }
}

