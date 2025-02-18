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

            writer.WriteLine(_totalPoints);
            foreach(Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(string filename)
    {
        
        using(StreamReader reader = new StreamReader(filename))
        {
            if(int.TryParse(reader.ReadLine(), out int savedPoints))
            {
                _totalPoints = savedPoints;
            }

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string [] parts = line.Split('|');
                string type = parts [0];
                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts [4]);
                    var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    goal.SetComplete(isComplete);
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (type == "ChecklistGoal")
                {

                    int targetCount = int.Parse(parts [4]);
                    int timesCompleted = int.Parse(parts [5]);

                    var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), targetCount, int.Parse(parts[6]));
                    goal.SetTimesCompleted(timesCompleted);
                    _goals.Add(goal);
                    /*_goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), targetCount, bonutPoints)
                    {
                        TimesCompleted = timesCompleted
                    });*/
                    
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