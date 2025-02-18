public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;
    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, int targetCount, int bonusPoints) 
        : base(goalName, goalDescription, goalPoints)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _timesCompleted ++;
        if (_timesCompleted == _targetCount)
        {
            return GetGoalPoints() + _bonusPoints;
        }
        return GetGoalPoints();
    }

    public void SetTimesCompleted(int completed)
    {
        _timesCompleted = completed;
    }

    /*public int GetBonusPoints()
    {
        return _bonusPoints;
    }*/
    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCount;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetGoalName()}  ({GetGoalDescription()}) -- Completed: {_timesCompleted}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal| {GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{_targetCount}|{_timesCompleted}|{_bonusPoints}";
    }


}