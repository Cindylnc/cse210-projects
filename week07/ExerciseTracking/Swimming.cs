public class Swimming: Activity
{

    public Swimming(string date, int lenght)
        : base(date, lenght)
        {
            
        }




    public override int GetDistance()
    {
        return 0;
    }

    public override int GetSpeed()
    {
       return 0;
    }
    public override int GetNumberofLamps()
    {
        return 0;
    }

}