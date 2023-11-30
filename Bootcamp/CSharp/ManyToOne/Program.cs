using Company;

namespace ManyToOne
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee() { EmployeeID = 1, EmployeeName = "Scott", Email = "scott@example.com" };
            Employee employee2 = new Employee() { EmployeeID = 2, EmployeeName = "John", Email = "john@example.com" };
            Employee employee3 = new Employee() { EmployeeID = 3, EmployeeName = "Allen", Email = "allen@example.com" };

            Department department = new Department() { DepartmentID = 10, DepartmentName = "Accounting" };
            employee1.dept = department;
            employee2.dept = department;
            employee3.dept = department;

            Console.WriteLine("First Employee");
            Console.WriteLine("Employee ID: " + employee1.EmployeeID);
            Console.WriteLine("Employee Name: " + employee1.EmployeeName);
            Console.WriteLine("Employee email: " + employee1.Email);
            Console.WriteLine("Department ID: " + employee1.dept.DepartmentID);
            Console.WriteLine("Department name: " + employee1.dept.DepartmentName);

            Console.WriteLine("Second Employee");
            Console.WriteLine("Employee ID: " + employee2.EmployeeID);
            Console.WriteLine("Employee Name: " + employee2.EmployeeName);
            Console.WriteLine("Employee email: " + employee2.Email);
            Console.WriteLine("Department ID: " + employee2.dept.DepartmentID);
            Console.WriteLine("Department name: " + employee2.dept.DepartmentName);

            Console.WriteLine("Third Employee");
            Console.WriteLine("Employee ID: " + employee3.EmployeeID);
            Console.WriteLine("Employee Name: " + employee3.EmployeeName);
            Console.WriteLine("Employee email: " + employee3.Email);
            Console.WriteLine("Department ID: " + employee3.dept.DepartmentID);
            Console.WriteLine("Department name: " + employee3.dept.DepartmentName);

        }
    }
}
