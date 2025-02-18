public abstract class Activity
{
    private string _date;
    private int _lenght;


    public Activity (string date, int lenght)
    {
        _date = date;
        _lenght = lenght;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _lenght;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $" {_date} {GetType().Name}  ({_lenght} min) - Distance: {GetDistance():0.0} miles, " 
        + $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";

    }

}