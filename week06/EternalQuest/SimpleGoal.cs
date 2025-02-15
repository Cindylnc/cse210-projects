using System.Linq.Expressions;

public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string goalName, string goalDescription, int goalPoints) 
        : base(goalName, goalDescription, goalPoints)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal| {_goalName} | {_goalDescription}|{_goalPoints}|{_isComplete}";
    }

}