using System;
using System.Security;

class Customer{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public string GetName(){
        return _name;
    }

    public Address GetAddress(){
        return _address;
    }


    public double GetShippingCost(){     // changed to reflect feedback from milestone submission
        if(_address.IsUsaAddress() == true){
            return 5;
        } else {
            return 35;
        }
    }

    public string GetFullAddress(){
        return _address.GetFullAddress();
    }
}