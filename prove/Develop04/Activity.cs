using System;

class Activity{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description){
        _name = name;
        _description = description;

    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.Write($"\nHow Long, in seconds, would you like for your session? ");
    }
    public void DisplayEndingMessage(){
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int seconds){
        List<string> slash = new List<string>();
        slash.Add("|");
        slash.Add("/");
        slash.Add("-");
        slash.Add("\\");
        slash.Add("|");
        slash.Add("/");
        slash.Add("-");
        slash.Add("\\");

        DateTime _dateTime = DateTime.Now;
        DateTime _endTime = _dateTime.AddSeconds(seconds);
        int y = 0;
        while(DateTime.Now <_endTime){
            string s = slash[y];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            y++;
            if(y >= slash.Count){
                y = 0;
            }
        }
    }
    public void ShowCountDown(int seconds){
        DateTime _dateTime = DateTime.Now;
        DateTime _endTime = _dateTime.AddSeconds(seconds);
        int y = seconds;
        while(DateTime.Now <_endTime){
            Console.Write(y);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            y--;
        }
    }

    public void GetReady(int seconds){
        Console.WriteLine("Get Ready...");
        ShowSpinner(seconds);
        Console.WriteLine("");
    }


}