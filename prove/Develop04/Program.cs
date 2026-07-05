using System;

// Exceed Requirements
// Dictionary for count each activity that the user made.

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,int> countActivity = new Dictionary<string,int>{
            {"Breathing", 0},
            {"Reflecting", 0},
            {"Listening", 0}
        };
        int s = 0;
        while (s != 4){
            Console.WriteLine("\nMenu options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start Listening activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            s = int.Parse(Console.ReadLine());
            Console.Clear();

            if (s == 1){
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                countActivity["Breathing"]++;
            } else if(s == 2){
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                countActivity["Reflecting"]++;
            } else if(s == 3){
                ListingActivity listing = new ListingActivity();
                listing.Run();
                countActivity["Listening"]++;
            } else if(s == 4){
                break;
            }
        }
        Console.Clear();
        Console.WriteLine("Congratulations!");
        Console.WriteLine($"{countActivity["Breathing"]} Breathing Activity");
        Console.WriteLine($"{countActivity["Reflecting"]} Reflecting Activity");
        Console.WriteLine($"{countActivity["Listening"]} Listening Activity");
    }
}