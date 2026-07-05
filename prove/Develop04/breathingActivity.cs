using System;

class BreathingActivity : Activity{
    public BreathingActivity():base("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){

    }
    public void Run(){
        Console.Clear();
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        Breathing();
        DisplayEndingMessage();
    }

    public void Breathing(){
        DateTime _dateTime = DateTime.Now;
        DateTime _endTime = _dateTime.AddSeconds(_duration);
        int breathIn = 2;
        int breathOut = 3;
        GetReady(4);
        while(DateTime.Now < _endTime){
            Console.WriteLine(" ");
            Console.Write("Breathe in...");
            ShowCountDown(breathIn);
            Console.WriteLine(" ");
            Console.Write("Now breathe out...");
            ShowCountDown(breathOut);
            Console.WriteLine(" "); 
            breathIn = 4;
            breathOut = 6;

        }
    }
}