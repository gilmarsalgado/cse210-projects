using System;

class Outdoor : Event{
    protected string _weather;

    public Outdoor(string title, string description, string date,string time,Address address,string weather):base(title,description,date,time,address){
        _weather = weather;
    
    }
    
    public override void GetFullDetails(){

        Console.WriteLine("");
        Console.WriteLine("Type: Outdoor");
        GetStandardDetails();
        Console.WriteLine($"Weather: {_weather}");
    }

    public override void GetShortDescription()
    {
        Console.WriteLine("");
        Console.WriteLine($"Outdoor - {_title} - {_date}");



    }

}