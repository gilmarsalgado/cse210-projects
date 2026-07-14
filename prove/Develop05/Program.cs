using System;

// Exceed Requirements
// I created i function to get 3 values (name,description and points) and after a called them using a var tuple that hold the 3 values.
//i did this to reuse the function in all 3 goals  

// New Function for Display Menu.
// New Function for Display the sub-menu in "Create new Goal".
// I used Try and Catch, if the user doesn't type correctly the options on menus.



class Program
{
    static void Main(string[] args)
    {
        // Create GoalManager Function 
        GoalManager goalManager= new GoalManager(0);
        // Run Start function
        goalManager.Start();
    }
    
}