using System;

class ReflectingActivity : Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity():base("Reflecting Activity","..."){
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public void Run(){
        Console.Clear();
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        GetReady(3);
        DisplayPrompt();
        DisplayQuestions();
        // I call it again for receive another random Prompt
        GetRandomQuestion();
        DisplayQuestions();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        Random random= new Random();
        int position = random.Next(0,_prompts.Count);
        return _prompts[position];
    }
    public string GetRandomQuestion(){
        Random random= new Random();
        int position=random.Next(0,_questions.Count);
        return _questions[position];
    }
    public void DisplayPrompt(){
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
    }
    public void DisplayQuestions(){
        Console.WriteLine($"> {GetRandomQuestion()}");
        ShowSpinner(15);
    }




}