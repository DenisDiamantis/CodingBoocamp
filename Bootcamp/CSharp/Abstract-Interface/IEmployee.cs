public interface IEmployee
{
    //abstract methods
    string GetHealthInsuranceAmount();

    //auto properties
    int EmpID { get; set; }
    string EmpName { get; set; }
    string Location { get; set; }
}

