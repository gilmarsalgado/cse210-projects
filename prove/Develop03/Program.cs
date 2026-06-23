using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

//What I did to exceed requirements:
//Added five different scriptures that will be randomly chosen as the program starts.
//Select a random number of words to be hidden each time (2 to 4 words).
//Only hide words that have not yet been hidden.
//Added a return OptionalAttribute so the scripture will be shown whole again.
//Added an exception to avoid mistakes when converting the user's input to lower case.



class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>(); //created library to hold scriptures

        // Creating Instances
        scriptureLibrary.Add(new Scripture(new Reference("D&C", 6, 36), "Therefore, fear not, little flock; do good; let earth and hell combine against you, for if ye are built upon my rock, they cannot prevail."));
        scriptureLibrary.Add(new Scripture(new Reference("2 Nefi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."));
        scriptureLibrary.Add(new Scripture(new Reference("Mosiah", 3, 19), "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."));

        bool programRunning = true;

        while (programRunning)
        {
            //Picking a random scripture from the library 
            Random random = new Random();
            int randomIndex = random.Next(scriptureLibrary.Count);
            
            // Grab the randomly selected scripture
            Scripture currentScripture = scriptureLibrary[randomIndex];
            
            // Cleaning Console
            Console.Clear();
            System.Console.WriteLine("     Welcome to our Scripture Memorizer     ");
            System.Console.WriteLine("--------------------------------------------------------------");
            System.Console.WriteLine(currentScripture.GetDisplayText());
            System.Console.WriteLine("--------------------------------------------------------------");
            System.Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            System.Console.WriteLine("Type 'Return' to get a new scripture.");

            bool finish = true;
            string userResponse;
            
            while (finish == true)
            {
                userResponse = Console.ReadLine();
                Console.Clear();
                
                // Hide words and print the updated scripture
                currentScripture.HideRandomWords();
                System.Console.WriteLine(currentScripture.GetDisplayText());
                System.Console.WriteLine("Press ENTER to continue or type 'QUIT' to finish: ");
                System.Console.WriteLine("Type 'Return' to get a new scripture.");
                
                // Convert input to lowercase safely
                userResponse = userResponse.ToLower();
                
                // Check if the user wants to quit, return, or if the scripture is fully hidden
                if (userResponse == "quit" || currentScripture.IsCompletelyHidden() == false)
                {
                    finish = false;
                    programRunning = false; // Ends the entire program
                } 
                else if (userResponse == "return")
                {
                    finish = false; // Breaks the inner loop, letting the outer loop pick a new scripture
                }
            }
        }
    }
}