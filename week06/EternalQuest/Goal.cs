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

    public void RecordEvent(string goalName)
    {
        _goalName = goalName;
    }

    public bool IsComplete()
    {
        return true;
    }

    public string GetDetailsString()
    {
        return _goalDescription;
    }

    public abstract string GetStringRepresentation();






}