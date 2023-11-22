namespace Constructors
{
    public class Employee
    {
        public uint EmployeeID;
        public string EmployeeName;
        public string EmployeeJob;

        public static string companyName;

        public Employee(uint EmployeeID, string EmployeeName, string EmployeeJob)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.EmployeeJob = EmployeeJob;
        }

        public Employee(uint EmployeeID, string EmployeeName)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;

        }

        public Employee()
        {
            EmployeeID = 1;
        }

        static Employee()
        {
            companyName = "ABC Industries";
        }
    }
}