namespace Inheritance
{
    //abstract class that doesnt implement the override
    public abstract class SalesMan : Employee
    {
        private string _region;

        public SalesMan(int empId, string empName, string empLocation, string region) : base(empId, empName, empLocation)
        {
            this._region = region;
        }

        public string Region { get => _region; set => _region = value; }

        public long GetSalesOfTheCurrentMonth()
        {
            return 1000;
        }
    }
}
