using System;

abstract class Event{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date,string time,Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void GetStandardDetails(){
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"{_date} @ {_time}");
        Console.WriteLine($"{_address.GetFullAddress()}");
    }

    public abstract void GetFullDetails();


    public abstract void GetShortDescription();

}