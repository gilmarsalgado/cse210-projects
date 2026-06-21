using System;


// Exceeding Requirements for this activity

// Verifying if exists something in List entries when the user type option 2 for Display
// Error message in case the user doesn't type a option between 1-5 
// Error message if the user hasn't written any in the journal
// A condition for verify if the file does exist when calling LoadFromFile
// Message informing the user that the file has been uploaded successfully


class Program
{
    static void Main(string[] args)
    {

        Journal _journal = new Journal();
        PromptGenerator _generator = new PromptGenerator();
        
        int userResponse = 0;
        while (userResponse != 5){

            PromptGenerator.PrintMenu();
            userResponse = int.Parse(Console.ReadLine());

            if (userResponse == 1)
            {
                Entry UserEntry = new Entry();
                UserEntry._promptText = PromptGenerator.GetRandomPrompt();
                Console.WriteLine(UserEntry._promptText);
                UserEntry._entryText = Console.ReadLine();
                //Creativity part for assignment
                Console.WriteLine("What is your mood right now?");
                UserEntry._mood = Console.ReadLine();

                DateTime datenow = DateTime.Now;
                UserEntry._date = datenow.ToShortDateString();
                _journal.AddEntry(UserEntry);
            }else if (userResponse == 2)
            {
                if (_journal._entries.Count == 0){
                    Console.WriteLine("\nERROR: There is nothing to Display");
                } else {_journal.DisplayAll();}
            } 
            else if (userResponse == 3)
            {
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();

                if (File.Exists(fileName)){
                    _journal.LoadFromFile(fileName);
                    Console.WriteLine("\nYour file has been updated successfully");
                } else {Console.WriteLine("This File doesn't exist");}

            } 
            else if (userResponse == 4)
            {
                if (_journal._entries.Count == 0){
                    Console.WriteLine("\nERROR: You haven't write nothing in your Journal yet");
                } else {
                    Console.WriteLine("What is the file name? ");
                    string fileName = Console.ReadLine();
                    _journal.SaveToFile(fileName);
                }

            } 
            else {
                if (userResponse == 5){} 
                else {Console.WriteLine("\nERROR: Please type a correct option (1-5)");}
            }

        }
        

    }
}