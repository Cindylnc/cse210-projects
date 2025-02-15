public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;


    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        return $"{_goalName} - {_goalDescription} ({_goalPoints} points)";
    }






}