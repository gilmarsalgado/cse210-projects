using System;

class Lecture : Event{
    protected string _speaker;
    protected int _capacity;

    public Lecture(string title, string description, string date,string time,Address address,string speaker,int capacity):base(title,description,date,time,address){
        _speaker = speaker;
        _capacity = capacity;
    }
    
    public override void GetFullDetails(){
        Console.WriteLine("");
        Console.WriteLine("Type: Lecture");
        GetStandardDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity {_capacity}");
    }

    public override void GetShortDescription()
    {
        Console.WriteLine("");
        Console.WriteLine($"Lecture - {_title} - {_date}");
        Console.WriteLine("============================================");
    }

}