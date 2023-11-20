public class MultipleObjectsExample
{
    static void Main()
    {
        //initialize static field
        Employee.OrganizationName = "ABC Inc.";
        System.Console.WriteLine("*****************" +
            Employee.OrganizationName
            + "*****************");
        //loop that executes 10 times for 10 empoyees
        for (int i = 0; i < 10; i++)
        {
            string employeeNumber;
            switch (i)
            {
                case 0: employeeNumber = "First Employee"; break;
                case 1: employeeNumber = "Second Employee"; break;
                case 2: employeeNumber = "Third Employee"; break;
                case 3: employeeNumber = "Fourth Employee"; break;
                case 4: employeeNumber = "Fifth Employee"; break;
                case 5: employeeNumber = "Sixth Employee"; break;
                case 6: employeeNumber = "Seventh Employee"; break;
                case 7: employeeNumber = "Eighth Employee"; break;
                case 8: employeeNumber = "Ninth Employee"; break;
                case 9: employeeNumber = "Tenth Employee"; break;
                default: employeeNumber = "Other Employee"; break;
            }
            System.Console.WriteLine(employeeNumber);

            //create an object for Employee class
            Employee employee = new Employee();

            //read EmployeeID from keyboard
            System.Console.Write("Employee ID: ");
            employee.EmployeeID = uint.Parse(System.Console.ReadLine());
            //read name
            System.Console.Write("Employee Name: ");
            employee.EmployeeName = System.Console.ReadLine();
            //read salary per hour
            System.Console.Write("Employee salary per hour: ");
            employee.SalaryPerHour = double.Parse(System.Console.ReadLine());
            // read number of working hours
            System.Console.Write("Employee number of working hours: ");
            employee.NoOfWorkingHours = double.Parse(System.Console.ReadLine());

            //calculate net salary
            employee.NetSalary = employee.SalaryPerHour * employee.NoOfWorkingHours;

            //Display Employee Details
            System.Console.WriteLine("\nDetails of " + employeeNumber);
            System.Console.WriteLine("Employee ID: " + employee.EmployeeID);
            System.Console.WriteLine("Employee Name: " + employee.EmployeeName);
            System.Console.WriteLine("Salary per hour: " + employee.SalaryPerHour);
            System.Console.WriteLine("Number of working hours: " + employee.NoOfWorkingHours);
            System.Console.WriteLine("Net salary: " + employee.NetSalary);
            System.Console.WriteLine("Type of Employee: " + Employee.TypeOfEmployee);
            System.Console.WriteLine("Department Name: " + employee.DepartmentName);

            System.Console.WriteLine("Do you want to continue to next employee? Yes/No");
            string choice = System.Console.ReadLine();

            if (!(choice.ToLowerInvariant() == "yes" || choice.ToLowerInvariant() == "y"))
            {
                break;
            }
            System.Console.WriteLine("----------------------------");
        }
        System.Console.WriteLine("\nThank you");
        System.Console.ReadKey();
    }
}