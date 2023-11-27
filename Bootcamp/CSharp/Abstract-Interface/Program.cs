class Program
{
    static void Main()
    {
        Manager mngr1 = new Manager(101, "Scott", "New York", "IT Department");
        System.Console.WriteLine(mngr1.GetHealthInsuranceAmount());
        System.Console.WriteLine(mngr1.GetFullDepartmentName());

        SalesMan slm1 = new SalesMan(102, "John", "London", "Chelsea");
        System.Console.WriteLine(slm1.Region);
        System.Console.WriteLine(slm1.GetSalesOfTheCurrentMonth());

        IEmployee employee1 = new Manager(103, "Mike", "New Jersey", "Finance");
        IPerson person = new Manager(104, "George", "Los Angeles", "HR Department");
    }
}