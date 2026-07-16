using System;
using System.Runtime.CompilerServices;

class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
    }

    public void AddProductToOrder(Product product){
        _products.Add(product);
    }

    public double GetTotalPrice(){
        double total = 0;
        foreach(var item in _products){
            total += item.CostCalculator();
        }
        return total+_customer.ISCustomerInUSA();
    }

    public void DisplayTotalPrice(){
        Console.WriteLine($"Total Cost: ${GetTotalPrice()}");
    }

    public void DisplayPacking(){
        Console.WriteLine("Packing Label");
        Console.WriteLine("=============");
        for (int i = 0; i < _products.Count; i++)
        {
            Console.WriteLine($"{_products[i].GetId()} - {_products[i].GetName()}");
        }
        Console.WriteLine("");
    }
    public void DisplayShipping(){
        Console.WriteLine("Shipping Label");
        Console.WriteLine("=============");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().GetFullAddress());
        Console.WriteLine("-------------------------------------------------------------");
    }




}