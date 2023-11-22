
namespace Properties
{
    public class test
    {
        private int employeeId;
        private string employeeName;
        private string job;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Job { get => job; set => job = value; }

        public test(int employeeId, string employeeName, string job)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.Job = job;
        }
    }
}
