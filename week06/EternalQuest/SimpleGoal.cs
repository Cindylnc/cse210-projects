using System.Linq.Expressions;

public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string goalName, string goalDescription, int goalPoints) 
        : base(goalName, goalDescription, goalPoints)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetGoalPoints();
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"[ {(IsComplete() ? "X" : " ")} ] {GetGoalName()} ({GetGoalDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{_isComplete}";
    }

}