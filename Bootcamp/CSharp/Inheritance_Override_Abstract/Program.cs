using Inheritance;

class Program
{
    static void Main()
    {
        // Employee emp1 = new Employee(101, "Scott", "New York");
        Employee emp1 = new Manager(101, "Scott", "New York", "HR");

        //emp1.EmpId = 101;
        //emp1.EmpName = "Scott";
        //emp1.EmpLocation = "New York";
        System.Console.WriteLine("Object of parent class (Employee)");
        System.Console.WriteLine(emp1.EmpId);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.EmpLocation);
        System.Console.WriteLine(emp1.GetHealthInsuranceAmount());
        System.Console.WriteLine();

        Manager mgr1 = new Manager(102, "Allen", "Rome", "Accounting");
        //mgr1.EmpId = 102;
        //mgr1.EmpName = "Allen";
        //mgr1.EmpLocation = "Rome";
        //mgr1.DepartmentName = "Accounting";
        System.Console.WriteLine("Object of child class (Manager)");
        System.Console.WriteLine(mgr1.EmpId);
        System.Console.WriteLine(mgr1.EmpName);
        System.Console.WriteLine(mgr1.EmpLocation);
        System.Console.WriteLine(mgr1.DepartmentName);
        System.Console.WriteLine(mgr1.GetFullDepartmentName());
        System.Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
        System.Console.WriteLine(mgr1.GetHealthInsuranceAmount());
        System.Console.WriteLine();

        //polymorphism
        Employee employee = new Manager(103, "John", "Athens", "IT");
        System.Console.WriteLine("Object of child class (Manager) acting like a parent object(Employee)");
        System.Console.WriteLine(employee.EmpId);
        System.Console.WriteLine(employee.EmpName);
        System.Console.WriteLine(employee.EmpLocation);
        System.Console.WriteLine(((Manager)employee).GetFullDepartmentName());
        System.Console.WriteLine(((Manager)employee).GetTotalSalesOfTheYear());
        //System.Console.WriteLine(employee.GetHealthInsuranceAmount());
        System.Console.WriteLine(((Manager)employee).GetHealthInsuranceAmount());
        System.Console.WriteLine();
    }
}