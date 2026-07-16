using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1= new Order(new Customer("Bob the builder",new Address("123 Elm St","New York City","NY","USA")));
        order1.AddProductToOrder(new Product("324A","Pencil",10,3));
        order1.AddProductToOrder(new Product("52AZ","Eraser",1.5,2));
        order1.DisplayTotalPrice();
        order1.DisplayPacking();
        order1.DisplayShipping();

        Order order2= new Order(new Customer("Big Ben",new Address("246 Oak Circle","London","England","UK")));
        order2.AddProductToOrder(new Product("852E","Paper",10,9));
        order2.AddProductToOrder(new Product("52AZ","Eraser",1.5,6));
        order2.DisplayTotalPrice();
        order2.DisplayPacking();
        order2.DisplayShipping();
        

        Order order3= new Order(new Customer("Luã Felizola",new Address("Av. Praia da Costa","Barra dos Coqueiros","SE","BR")));
        order3.AddProductToOrder(new Product("324A","Pencil",10,5));
        order3.AddProductToOrder(new Product("52AZ","Eraser",1.5,6));
        order3.AddProductToOrder(new Product("852E","Paper",10,9));
        order3.DisplayTotalPrice();
        order3.DisplayPacking();
        order3.DisplayShipping();


    }
}