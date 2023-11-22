namespace Properties
{
    public class Employee
    {
        private int _employeeId;
        private string _employeeName;
        private string _job;
        private double _salary;
        public string NativePlace { get; set; } = "New York";

        public int EmployeeId { get { return _employeeId; } set { _employeeId = value; } }

        public string EmployeeName { get { return _employeeName; } set { _employeeName = value; } }


        public string Job { get { return _job; } set { _job = value; } }

        private static string _companyName;

        public static string CompanyName
        {
            get { return _companyName; }
            set { if (value.Length <= 20) { _companyName = value; } }
        }

        //readOnly
        public double Salary { get => _salary; }

        public Employee(int employee, string employeeName, string job)
        {
            this._employeeId = employee;
            this._employeeName = employeeName;
            this._job = job;
        }
    }
}
