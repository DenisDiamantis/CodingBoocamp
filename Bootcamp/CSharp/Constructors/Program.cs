using Constructors;

class Program
{

    static void Main()
    {
        Employee emp1 = new Employee(101, "Scott", "Manager");
        Employee emp2 = new Employee(102, "Allen", "Asst. Manager");
        Employee emp3 = new Employee(103, "Anna", "Marketing");

        Employee emp4 = new Employee();
        emp4.EmployeeID = 104;
        emp4.EmployeeName = "Michael";
        emp4.EmployeeJob = "Trainer";

        Employee emp5 = new Employee(105, "John");
        emp5.EmployeeJob = "IT Manager";

        //object initializer
        Employee emp6 = new Employee() { EmployeeName = "Ford", EmployeeJob = "Executive" };

        System.Console.WriteLine("First employee: ");
        System.Console.WriteLine("Company name: " + Employee.companyName);
        System.Console.WriteLine("Employee ID: " + emp1.EmployeeID);
        System.Console.WriteLine("Employee Name: " + emp1.EmployeeName);
        System.Console.WriteLine("Employee Job: " + emp1.EmployeeJob);

        System.Console.ReadKey();
    }
}