namespace Inheritance
{
    //abstact prevent employee object creation
    public abstract class Employee
    {
        private int _empId;
        private string _empName;
        private string _empLocation;


        public Employee(int empId, string empName, string empLocation)
        {
            this._empId = empId;
            this._empName = empName;
            this._empLocation = empLocation;
        }
        public int EmpId { get => _empId; set => _empId = value; }
        public string EmpName { get => _empName; set => _empName = value; }
        public string EmpLocation { get => _empLocation; set => _empLocation = value; }


        // virtual so it can be overriden

        //public virtual string GetHealthInsuranceAmount()
        //{
        //    return "Health Insurance Amount is " + 500;
        //}

        public abstract string GetHealthInsuranceAmount();


    }
}
