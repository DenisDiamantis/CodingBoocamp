public class DVD : ILoanable, IPrint
{
    private string _title;
    private string _director;
    private int _lengthInMinutes;
    private string _borrower;
    private int _loanPeriod = 21;
    private bool _isBorrowed = false;

    public DVD(string title, string director, int lengthInMinutes)
    {
        Title = title;
        this._director = director;
        LengthInMinutes = lengthInMinutes;
    }

    public string Title { get => _title; set => _title = value; }
    public int LengthInMinutes { get => _lengthInMinutes; set => _lengthInMinutes = value; }
    public string Borrower { get => _borrower; set => _borrower = value; }
    public int LoanPeriod { get => _loanPeriod; set => _loanPeriod = value; }
    public bool IsBorrowed { get => _isBorrowed; set => _isBorrowed = value; }
    public string Director { get => _director; set => _director = value; }

    public void Borrow(string borrower)
    {
        if (!IsBorrowed) { Borrower = borrower; IsBorrowed = true; }
    }

    public void Print()
    {
        if (!IsBorrowed)
        {
            System.Console.WriteLine($"The DVD {Title} directed by {Director} is available.");
        }
        else
        {
            System.Console.WriteLine($"The DVD {Title} directed by {Director} was borrowed by {Borrower}.");
        }


    }

    public void Return()
    {
        IsBorrowed = false;
        Borrower = "";
    }
}