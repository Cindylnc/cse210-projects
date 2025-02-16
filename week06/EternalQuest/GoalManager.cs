public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    
    public void AddGoal(Goal goal) 
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.GetGoalName() == goalName)
            {
                _totalPoints += goal.RecordEvent();
                return;
            }
        }
        Console.WriteLine($"Goal not found x_x");
    }


    public void ListGoal()
    {
        for (int i = 0; i <_goals.Count; i++)
        {
            Console.WriteLine($"{i = 1}. {_goals[i].GetDetailsString}");
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