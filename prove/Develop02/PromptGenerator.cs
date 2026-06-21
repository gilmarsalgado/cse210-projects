using System;

public class PromptGenerator{ // Supplies random prompts whenever needed.
    public static List<string> _prompts = new List<string>(){
        "Who did i help today?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do over today, what would it be?",
        "What haven't I done today that i can do tomorrow?",
        "What was the strongest emotion I felt today?",
        "What am i grateful to God today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?"
    };
    
    public static void PrintMenu(){ 
        Console.WriteLine("\nPlease select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }
   
    public static string GetRandomPrompt(){
        Random random= new Random(); 
        int position = random.Next(0,_prompts.Count);
        return _prompts[position];
    }

}