using System;

class Product{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;


    public Product(string id, string name, double price, int quantity){
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName(){
        return _name;
    }

    public string GetId(){
        return _id;
    }

    public double CostCalculator(){
        return _price * _quantity;
    }


}