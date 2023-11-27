/*
public class Manager : IEmployee
{

    private string _department;
    public Manager(int empID, string empName, string location, string department) : base(empID, empName, location)
    {
        this._department = department;
    }

    public string Department { get => _department; set => _department = value; }


    public long GetTotalSalesOfTheYear() { return 100000; }
    public override string GetHealthInsuranceAmount()
    {

        return "Manager Health Insurance amount is: " + 1000;
    }

    public string GetFullDepartmentName() { return Department + " (" + base.Location + ")"; }
}
*/




class Manager : IEmployee, IPerson
{
    private string _department;
    private int _empID;
    private string _empName;
    private string _location;
    private System.DateTime _dateOfBirth;

    public Manager(int empID, string empName, string location, string department)
    {
        _empID = empID;
        _empName = empName;
        _location = location;
        _department = department;
    }

    public string Department { get => _department; set => _department = value; }
    public int EmpID { get => _empID; set => _empID = value; }
    public string EmpName { get => _empName; set => _empName = value; }
    public string Location { get => _location; set => _location = value; }
    public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }

    public string GetHealthInsuranceAmount()
    {
        return "Manager Health Insurance amount is: " + 1000;
    }
    public string GetFullDepartmentName() { return Department + " (" + Location + ")"; }

    public int GetAge()
    {
        int age = System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays / 365);
        return age;
    }
}
