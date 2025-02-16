using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine("");


        GoalManager goalManager= new GoalManager();

        while (true)
        {
            Console.WriteLine($"\nYou have {goalManager.GetTotalPoints()} points.\n");
            Console.WriteLine("Meny Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nSelect Goal Type:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Enter the number for goal type: ");

                string goalType = Console.ReadLine();

                Console.Write("What is the goal name? ");
                string name = Console.ReadLine();

                Console.Write("What is the goal description? ");
                string description = Console.ReadLine();

                Console.Write("How many points would you like to associate with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (goalType == "1")
                {
                    goalManager.AddGoal(new SimpleGoal(name, description,points));
                }
                else if (goalType == "2")
                {
                    goalManager.AddGoal(new EternalGoal(name, description,points));
                }
                else if (goalType == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                    int targetCount = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    goalManager.AddGoal(new ChecklistGoal (name, description, points, targetCount, bonusPoints));

                }
                else
                {
                    Console.
                    WriteLine("Invalid selection. Enter 1, 2, or 3");
                }
            }

            else if (choice == "2")
            {
                goalManager.ListGoals();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                goalManager.SaveGoals(saveFile);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                goalManager.LoadGoals(loadFile);
            }
            else if (choice == "5")
            {
                goalManager.ListGoals();

                Console.Write("Which goal did you accomplish? (Enter number): ");
                if (int.TryParse(Console.ReadLine(), out int goalIndex))
                {
                    goalManager.RecordEvent(goalIndex - 1);
                }
                else{
                    Console.Write("Invalid input. Please enter a number.");
                }
                
            }
            else if (choice == "6")
            {
                Console.WriteLine("Exiting program...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again");
            }


        }
    }
}