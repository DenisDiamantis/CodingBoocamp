namespace Inheritance
{
    //PREVENT INHERITANCE
    sealed public class Manager : Employee
    {
        private string _departmentName;

        public Manager(int empId, string empName, string empLocation, string department) : base(empId, empName, empLocation)
        {
            this._departmentName = department;
        }

        public long GetTotalSalesOfTheYear()
        {
            return 100000;
        }

        public string DepartmentName { get => _departmentName; set => _departmentName = value; }

        public string GetFullDepartmentName()
        {
            return DepartmentName + " at " + base.EmpLocation;
        }
        // override
        public override string GetHealthInsuranceAmount()
        {

            //System.Console.WriteLine(base.GetHealthInsuranceAmount());
            return "AS A MANAGER YOU GET Health Insurance Amount is " + 1500;
        }
    }
}
