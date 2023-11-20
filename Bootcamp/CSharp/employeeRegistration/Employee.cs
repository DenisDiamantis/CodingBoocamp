public class Employee
{
    //normal fields
    public uint EmployeeID;
    public string EmployeeName;
    public double SalaryPerHour;
    public double NoOfWorkingHours;
    public double NetSalary;

    //static field
    public static string OrganizationName;
    //constant
    public const string TypeOfEmployee = "Contract based";
    //readyonly field
    public readonly string DepartmentName;

    public Employee()
    {
        DepartmentName = "Finance Department";
    }

}