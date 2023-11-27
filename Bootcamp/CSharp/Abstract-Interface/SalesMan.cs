
public class SalesMan : Employee
{
    private string _region;
    public SalesMan(int empID, string empName, string location, string region) : base(empID, empName, location)
    {
        Region = region;
    }

    public string Region { get => _region; set => _region = value; }

    public override string GetHealthInsuranceAmount()
    {
        return "Salesman Health Insurance amount is: " + 500;
    }

    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }
}

