using System;

class Reception : Event{
    private string _email;

    public Reception(string title, string description, string date,string time,Address address,string email):base(title,description,date,time,address){
        _email = email;
    }
    
    public override string GetFullDetails(){
        return $"\nType: Reception\n{GetStandardDetails()}\nEmail: {_email}";
    }

    public override string GetShortDescription()
    {
        return $"\nReception - {GetTitle()} - {GetDate()}\n============================================";

    }

}