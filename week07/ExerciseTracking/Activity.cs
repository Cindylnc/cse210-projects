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

    public int Getlenght()
    {
        return _lenght;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return 0;
    }

}