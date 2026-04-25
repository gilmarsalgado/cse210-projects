using System;

class Program
{
    static void Main(string[] args)
    {
Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string final = "";

        if (percent >= 90)
        {
            final = "A";
        }
        else if (percent >= 80)
        {
            final = "B";
        }
        else if (percent >= 70)
        {
            final = "C";
        }
        else if (percent >= 60)
        {
            final = "D";
        }
        else
        {
            final = "F";
        }

        Console.WriteLine($"Your final grade is: {final}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do it!");
        }
    }
}