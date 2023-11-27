public abstract class Employee
{
    private int _empID;
    private string _empName;
    private string _location;

    public Employee(int empID, string empName, string location)
    {
        _empID = empID;
        _empName = empName;
        _location = location;
    }
    //public virtual string GetHealthInsuranceAmount()
    //{
    //    return "Health Insurance amount is: " + 500;
    //}
    public abstract string GetHealthInsuranceAmount();
    public int EmpID { get => _empID; set => _empID = value; }
    public string EmpName { get => _empName; set => _empName = value; }
    public string Location { get => _location; set => _location = value; }

}
