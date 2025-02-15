public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;


    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public int GetPoints()
    {
        return _goalPoints;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        return $"{_goalName} - {_goalDescription} ({_goalPoints} points)";
    }






}