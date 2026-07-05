using System;

class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() :base("ListingActivity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run(){
        Console.Clear();
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        GetRandomPrompt();
        DisplayPrompt();
        GetListFromUser();
        Console.WriteLine($"\nYou Listed {_count} items!");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        Random random= new Random();
        int position = random.Next(0,_prompts.Count);
        return _prompts[position];
    }

    public void DisplayPrompt(){
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        GetReady(3);
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
    }
    public void GetListFromUser(){
        DateTime _endTime = DateTime.Now.AddSeconds(_duration); 
        while(DateTime.Now < _endTime){
            Console.Write("> ");
            _prompts.Add(Console.ReadLine());
            _count++;
        }
    }
}