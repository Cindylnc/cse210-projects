public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
    public void ListGoalNames ()
    {

    }
    public void ListGoalDetails ()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal(Goal newGoal) 
    {
        _goals.Add(newGoal);
    }
    public void RecordEvent(int goalIndex)
    {
        if(goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex].IsComplete() ? _goals[goalIndex]._goalPoints : 0;
        }
    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }





}