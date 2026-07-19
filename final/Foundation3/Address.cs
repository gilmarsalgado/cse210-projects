using System;

class Address{
    protected string _street;
    protected string _city;
    protected string _state;
    protected string _country;

    public Address(string street, string city, string state, string country) {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public Address(){

    }
    public bool IsUsaAddress(){
        if(_country == "USA"){
            return true;
        } else {
            return false;
        }
    }
    public string GetFullAddress(){
        return $"{_street} \n{_city}, {_state}, {_country}";
    }


}