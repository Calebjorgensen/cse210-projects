using System;
public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name)
    {
        _name = name;
        _address = address;

    }
    public bool isFromUSA()
    {
        if(_address.isUSA() == true){
            return true;
        } else {
            return false;
        }
    }
    public string GetName()
    {
        return _name;
    }
    public string GenerateAddress()
    {
        string generateAddress = _address.GenerateAddress();
        return generateAddress;
    }
}
