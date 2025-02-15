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

    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }



    /*public void ListGoalDetails ()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }*/







}