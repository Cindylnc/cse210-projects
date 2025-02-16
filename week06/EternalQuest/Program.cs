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
            Console.WriteLine($"You have {goalManager.TotalPoints} points.\n");
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
                Console.WriteLine("\nSlect Goal Type:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("Enter the number for goal type: ");

                string goalType = Console.ReadLine();

                Console.WriteLine("Goal name:");
                string name = Console.ReadLine();

                Console.WriteLine("Goal description:");
                string description = Console.ReadLine();

                Console.WriteLine("Points:");
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
                    Console.Write("Target count: ");
                    int targetCount = int.Parse(Console.ReadLine());

                    Console.Write("Bonus Points: ");
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