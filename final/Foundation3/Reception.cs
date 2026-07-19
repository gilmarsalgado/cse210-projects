using System;

class Reception : Event{
    protected string _email;

    public Reception(string title, string description, string date,string time,Address address,string email):base(title,description,date,time,address){
        _email = email;
    }
    
    public override void GetFullDetails(){
        Console.WriteLine("");
        Console.WriteLine("Type: Reception");
        GetStandardDetails();
        Console.WriteLine($"Email: {_email}");
    }

    public override void GetShortDescription()
    {
        Console.WriteLine("");
        Console.WriteLine($"Reception - {_title} - {_date}");
        Console.WriteLine("============================================");

    }

}