using System;
using System.Runtime.InteropServices;

//What I did to exceed requirements:
//Select a random number of words to be hidden each time (2 to 4 words).
//Only hide words that have not yet been hidden.
//Added a return OptionalAttribute so the scripture will be shown whole again.
//Added an exception to avoid mistakes when converting the user's input to lower case.

class Program
{
    static void Main(string[] args)
    {
        // Creating Instances
        Reference reference1 = new Reference("D&C", 6,36);
        Scripture scripture1 = new Scripture(reference1, "Therefore, fear not, little flock; do good; let earth and hell combine against you, for if ye are built upon my rock, they cannot prevail.");
        // Cleaning Console
        Console.Clear();
        System.Console.WriteLine("     Welcome to our Scripture Memorizer     ");
        System.Console.WriteLine("--------------------------------------------------------------");
        System.Console.WriteLine(scripture1.GetDisplayText());
        System.Console.WriteLine("--------------------------------------------------------------");
        System.Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        System.Console.WriteLine("Type 'Return' to get the full scripture.");

        bool finish = true;
        string userResponse;
        while (finish == true){
            userResponse = Console.ReadLine();
            Console.Clear();
            scripture1.HideRandomWords();
            System.Console.WriteLine(scripture1.GetDisplayText());
            System.Console.WriteLine("Press ENTER to continue or type 'QUIT' to finish: ");
            System.Console.WriteLine("Type 'Return' to get the full scripture.");
            userResponse = userResponse.ToLower();
            if (userResponse == "quit" || scripture1.IsCompletelyHidden() == false){
                finish = false;
            } else if (userResponse == "return"){
                Main(args);
            }
        }
    }
}