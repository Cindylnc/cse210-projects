public abstract class Activity
{
    protected string _date;
    protected int _lenght;

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

    public abstract int GetDistance();
    public abstract int GetSpeed();
    public abstract int GetNumberofLamps();

    public abstract string GetSummary();

}