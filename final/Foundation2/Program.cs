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

        Order order2= new Order(new Customer("Gadfield Elm Chapel",new Address("Mill Ln","Gloucester ","England","UK")));
        order2.AddProductToOrder(new Product("852E","Paper",10,9));
        order2.AddProductToOrder(new Product("52AZ","Eraser",1.5,6));
        order2.DisplayTotalPrice();
        order2.DisplayPacking();
        order2.DisplayShipping();
        

        Order order3= new Order(new Customer("Yasmin Feitoza",new Address("Rua dos Papagaios, 945","Canela","RS","BR")));
        order3.AddProductToOrder(new Product("324A","Pencil",10,5));
        order3.AddProductToOrder(new Product("52AZ","Eraser",1.5,6));
        order3.AddProductToOrder(new Product("852E","Paper",10,9));
        order3.DisplayTotalPrice();
        order3.DisplayPacking();
        order3.DisplayShipping();


    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();         // updated to reflect feedback from milestone submission


        orders.Add(new Order(new Customer("Bob the builder",new Address("123 Elm St","New York City","NY","USA"))));
        orders[0].AddProductToOrder(new Product("324A","Pencil",10,3));
        orders[0].AddProductToOrder(new Product("52AZ","Eraser",1.5,2));

        orders.Add(new Order(new Customer("Gadfield Elm Chapel",new Address("Mill Ln","Gloucester ","England","UK"))));
        orders[1].AddProductToOrder(new Product("852E","Paper",10,9));
        orders[1].AddProductToOrder(new Product("52AZ","Eraser",1.5,6));

        orders.Add(new Order(new Customer("Yasmin Feitoza",new Address("Rua dos Papagaios, 945","Canela","RS","BR"))));
        orders[2].AddProductToOrder(new Product("324A","Pencil",10,5));
        orders[2].AddProductToOrder(new Product("52AZ","Eraser",1.5,6));
        orders[2].AddProductToOrder(new Product("852E","Paper",10,9));

        foreach(Order order in orders)
        {
            order.DisplayTotalPrice();
            order.DisplayPacking();
            order.DisplayShipping();
        }
    }
}