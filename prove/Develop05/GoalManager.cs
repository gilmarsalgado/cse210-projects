using System;

class GoalManager{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(int score){
        _score = score;
    }

    public void Start(){
        // Loop until quit
        int mainMenuInput = 0;
        while(mainMenuInput != 6){
            // Display the main menu & display player info
                DisplayPlayerInfo();
                DisplayMainMenu();
                // Creating a Try for deal with Format erros (When user type a string instead of number)
                try{mainMenuInput = int.Parse(Console.ReadLine());}
                catch (FormatException){Console.WriteLine("Wrong Input! Please type a number");}
                // Condition to verify the option selected
                // Call: (Create Goal, ListGoalDetails, SaveGoals, LoadGoals, RecordEvent)
                if(mainMenuInput == 1){
                    CreateGoal();
                } else if(mainMenuInput == 2){
                    ListGoalDetails();
                } else if(mainMenuInput == 3){
                    SaveGoals();
                } else if(mainMenuInput == 4){
                    LoadGoals();
                } else if(mainMenuInput == 5){
                    RecordEvent();
                } else if(mainMenuInput == 6){
                    break;
                } else {
                    Console.WriteLine("Please type a option between 1-6");
                }
                
        }
    }
    public void DisplayPlayerInfo(){
        // Display the points
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    public void DisplayMainMenu(){
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    
    public void DisplaySubMenu(){
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
    }
   
   // Function to get Name Desc and Points
    public (string,string,int) GetNameDescPoints(){
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
        return (name,description,points);
    }
    public void ListGoalName(){
        for(int i = 0; i < _goals.Count; i++){
            Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
        }
    }
    public void ListGoalDetails(){
        for(int i = 0; i < _goals.Count; i++){
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal(){
        // display sub-menu and select goal type
        DisplaySubMenu();
        int subMenuInput = 0;
        // Creating a Try for deal with Format erros (When user type a string instead of number)
        try{subMenuInput = int.Parse(Console.ReadLine());}
        catch (FormatException){Console.WriteLine("Wrong Input! Please type a number");}
        if (subMenuInput == 1){
            // Creating a Tuple "var" to hold the return of 3 variables
            var nameDescPoints = GetNameDescPoints();
            SimpleGoal simpleGoal1 = new SimpleGoal(nameDescPoints.Item1,nameDescPoints.Item2,nameDescPoints.Item3,false);
            _goals.Add(simpleGoal1);

        } else if(subMenuInput == 2){
            var nameDescPoints = GetNameDescPoints();
            EternalGoal eternalGoal1 = new EternalGoal(nameDescPoints.Item1,nameDescPoints.Item2,nameDescPoints.Item3);
            _goals.Add(eternalGoal1);
    
        } else if(subMenuInput == 3){
            var nameDescPoints = GetNameDescPoints();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplising it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal1 = new ChecklistGoal(nameDescPoints.Item1,nameDescPoints.Item2,nameDescPoints.Item3,target,bonus);
            _goals.Add(checklistGoal1);

        } else Console.WriteLine("Please type a number between 1-3");
    
    }
    public void SaveGoals(){
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using(StreamWriter saveGoals = new StreamWriter(fileName)){
            saveGoals.WriteLine(_score);
            for (int i = 0; i < _goals.Count; i++){
                saveGoals.WriteLine(_goals[i].GetStringRepresentation());
            }
        }
        Console.WriteLine("\n-----Your file has been save------");
    }
    public void LoadGoals(){
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if(parts[0]=="Simple Goal:"){
                SimpleGoal simpleGoal1 = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]));
                _goals.Add(simpleGoal1);
            } else if(parts[0]=="Eternal Goal:"){
                EternalGoal eternalGoal1 = eternalGoal1 = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]));
                _goals.Add(eternalGoal1);
            }else if(parts[0]=="Check List Goal:"){
                ChecklistGoal checklistGoal1 = new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]));
                _goals.Add(checklistGoal1);
            }
        }
        Console.WriteLine("\n------Your file has been uploaded successfully------");
    }
    public void RecordEvent(){
        ListGoalName();
        Console.Write("\nWhich goal did you accomplish? ");
        int recordInput = 0;
        try{recordInput = int.Parse(Console.ReadLine());}
        catch (FormatException){Console.WriteLine("Error! Please type the Goal's number");}
        // Getting the points for the assignment
        int goalPoints = _goals[recordInput-1].RecordEvent();
        Console.WriteLine($"\nCongratulations! You have earned {goalPoints} points.");
        _score += goalPoints;
    }
}