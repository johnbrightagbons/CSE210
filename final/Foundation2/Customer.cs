using System;

namespace Foundation2
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            this._name = name;
            this._address = address;
        }

        // Check if the customer's address is in the USA
        public bool IsInUSA()
        {
            return _address.IsInUSA();
        }

        public string GetFullAddress()
        {
            return _address.GetFullAddress();
        }

        // Getter for private variable
        public string Name { get { return _name; } }
    }
}
