public class Job
{
    public string _company;
    public string _jobTile;
    public int _startYear;
    public int _endYear;

    public string DisplayJobDetails()
    {
        return _jobTile + " (" + _company + ") " + _startYear+"-"+ _endYear;
    }

}