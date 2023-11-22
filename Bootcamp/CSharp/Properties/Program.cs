using Properties;

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee(101, "Scott", "Manager");
        emp1.EmployeeId = 102;
        System.Console.WriteLine(emp1.EmployeeId);

    }
}