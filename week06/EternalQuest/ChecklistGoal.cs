public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, int target, int bonus) 
        : base(goalName, goalDescription, goalPoints)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal | {_goalDescription} | {_goalPoints}|{_amountCompleted}/{_target}|{_bonus}";
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" - Completed {_amountCompleted}/{_target} times";
    }


}