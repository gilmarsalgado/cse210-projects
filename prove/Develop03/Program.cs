using System;
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
        bool programRunning = true;
        Random random = new Random();

        while (programRunning)
        {
            // 1. Pick a random number ONCE at the start of a new scripture session
            int randomIndex = random.Next(3);
            bool workingOnSameScripture = true;

            while (workingOnSameScripture)
            {
                // 2. Rebuild the library inside this loop so the words are fresh and unhidden
                List<Scripture> scriptureLibrary = new List<Scripture>();

                scriptureLibrary.Add(new Scripture(new Reference("D&C", 6, 36), "Therefore, fear not, little flock; do good; let earth and hell combine against you, for if ye are built upon my rock, they cannot prevail."));
                scriptureLibrary.Add(new Scripture(new Reference("2 Nefi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."));
                scriptureLibrary.Add(new Scripture(new Reference("Mosiah", 3, 19), "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."));

                // 3. Grab the scripture using the SAME index
                Scripture currentScripture = scriptureLibrary[randomIndex];
                
                Console.Clear();
                Console.WriteLine("     Welcome to our Scripture Memorizer     ");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Press ENTER to continue or type 'QUIT' to finish.");
                Console.WriteLine("Type 'RETURN' to show this scripture whole again.");

                bool scriptureSession = true;
                string userResponse;
                
                while (scriptureSession)
                {
                    userResponse = Console.ReadLine()?.ToLower();
                    
                    if (userResponse == "quit")
                    {
                        scriptureSession = false;
                        workingOnSameScripture = false;
                        programRunning = false; 
                    } 
                    else if (userResponse == "return")
                    {
                        // Breaks this inner loop, but workingOnSameScripture remains true!
                        // This loops back, recreates the library, and pulls the exact same scripture, unhidden.
                        scriptureSession = false; 
                    }
                    else
                    {
                        // User pressed ENTER to hide words
                        Console.Clear();
                        currentScripture.HideRandomWords();
                        Console.WriteLine("     Welcome to our Scripture Memorizer     ");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine(currentScripture.GetDisplayText());
                        Console.WriteLine("--------------------------------------------------------------");
                        
                        if (currentScripture.IsCompletelyHidden())
                        {
                            Console.WriteLine("\nAll words are hidden! Press ENTER for a NEW scripture, or type 'RETURN' to show this one whole again.");
                            userResponse = Console.ReadLine()?.ToLower();
                            
                            if (userResponse == "quit") 
                            {
                                scriptureSession = false;
                                workingOnSameScripture = false;
                                programRunning = false;
                            }
                            else if (userResponse == "return") 
                            {
                                scriptureSession = false; // Restarts the same scripture
                            } 
                            else 
                            {
                                // User pressed enter to move on to a NEW scripture
                                scriptureSession = false;
                                workingOnSameScripture = false; // Breaks out to pick a new random index
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Press ENTER to continue or type 'QUIT' to finish.");
                            Console.WriteLine("Type 'RETURN' to show this scripture whole again.");
                        }
                    }
                }
            }
        }
    }
}