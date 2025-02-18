public class Biking: Activity
{
    private double _speed;

    public Biking(string date, int lenght, double speed)
        : base(date, lenght)
        {
            _speed = speed;
        }




    public override double GetDistance()
    {
        return _speed * Getlenght() / 60;
    }

    public override double GetSpeed()
    {
       return _speed;
    }
    public override double GetPace()
    {
        return 60/ _speed;
    }

}