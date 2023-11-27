public interface ILoanable
{
    int LoanPeriod { get; set; }
    string Borrower { get; set; }
    bool IsBorrowed { get; set; }
    void Borrow(string borrower);
    void Return();
}
