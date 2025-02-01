public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;


    public Address(string street, string city, string state)
    {
    }

    public bool IsInUSA()
    {
        return _city == ""; 
    }
    public string GetAddress()
    {
        return ("");
    }
}