using System;
public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool fromUS()
    {
        return _address.isUS() ? true : false;
    }
    public string GetName()
    {
        return _name;
    }
    public string GenerateAddress()
    {
        string generatedAddress = _address.GenerateAddress();
        return generatedAddress;
    }
}