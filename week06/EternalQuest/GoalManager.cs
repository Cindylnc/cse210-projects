public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    
    public void AddGoal(Goal goal) 
    {
        _goals.Add(goal);
    }


    /*public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _totalPoints += _goals[goalIndex].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }*/

    public void RecordEvent()
    {
        Console.WriteLine("\nThe current goals are:");
        for (int i = 0; i <_goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }

        Console.Write("Which goal did you accomplish? (Enter number): ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex - 1];
            int earnedPoints = selectedGoal.RecordEvent();

            _totalPoints += earnedPoints;

            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                /*int totalBonus = earnedPoints + checklistGoal.GetBonusPoints();
                _totalPoints += checklistGoal.GetBonusPoints();*/
                Console.WriteLine($"BONUS POINTS earned - Congratulations!! You have earned {earnedPoints} points!");
            }
            else 
            {
                Console.WriteLine($"\nCongratulations! You have earned {earnedPoints} points!");
            }
            Console.WriteLine($"You now have {_totalPoints} points total\n");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again");
        }
    }





    public void ListGoals()
    {
 
        if (_goals.Count == 0)
        {
            Console.WriteLine("\n**List of Goals** ");
            return;
        }

        Console.WriteLine("\n**List of Goals** ");
        for (int i=0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }



        
    }

    
    public void DisplayTotalPoints()
    {
        Console.WriteLine ($"Total Points: {_totalPoints}");
    }

    public void SaveGoals(string filename)
    {
        using(StreamWriter writer = new StreamWriter(filename))
        {
            foreach(Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(string filename)
    {
        _goals.Clear();
        using(StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string [] parts = line.Split('|');
                string type = parts [0];
                if (type == "1")
                {
                    _goals.Add( new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (type == "2")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (type == "3")
                {
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                }
            }
        }
    }



    /*public void ListGoalDetails ()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }*/







}