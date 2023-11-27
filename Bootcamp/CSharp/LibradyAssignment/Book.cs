public class Book : ILoanable, IPrint
{
    private string _author;
    private string _title;
    private string _IBSN;
    private string _borrower;
    private int _loanPeriod = 21;
    private bool _isBorrowed = false;

    public Book(string author, string title, string iBSN)
    {
        _author = author;
        _title = title;
        _IBSN = iBSN;
    }

    public string Author { get => _author; set => _author = value; }
    public string Title { get => _title; set => _title = value; }
    public string IBSN { get => _IBSN; set => _IBSN = value; }
    public int LoanPeriod { get => _loanPeriod; set => _loanPeriod = value; }
    public string Borrower { get => _borrower; set => _borrower = value; }
    public bool IsBorrowed { get => _isBorrowed; set => _isBorrowed = value; }

    public void Borrow(string borrower)
    {
        if (!IsBorrowed) { Borrower = borrower; IsBorrowed = true; }

    }

    public void Print()
    {
        if (!IsBorrowed)
        {
            System.Console.WriteLine($"The book {Title} by {Author} is available.");
        }
        else
        {
            System.Console.WriteLine($"The book {Title} by {Author} was borrowed by {Borrower}.");
        }
    }

    public void Return()
    {
        IsBorrowed = false;
        Borrower = "";
    }
}

