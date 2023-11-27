public class CD : ILoanable, IPrint
{
    private string _title;
    private string _artist;
    private int _numberOfTracks;
    private string _borrower;
    private int _loanPeriod = 21;
    private bool _isBorrowed = false;

    public CD(string title, string artist, int numberOfTracks)
    {
        Title = title;
        Artist = artist;
        NumberOfTracks = numberOfTracks;
    }

    public string Title { get => _title; set => _title = value; }
    public string Artist { get => _artist; set => _artist = value; }
    public int NumberOfTracks { get => _numberOfTracks; set => _numberOfTracks = value; }
    public string Borrower { get => _borrower; set => _borrower = value; }
    public int LoanPeriod { get => _loanPeriod; set => _loanPeriod = value; }
    public bool IsBorrowed { get => _isBorrowed; set => _isBorrowed = value; }

    public void Borrow(string borrower)
    {
        throw new NotImplementedException();
    }

    public void Print()
    {
        if (!IsBorrowed)
        {
            System.Console.WriteLine($"The CD {Title} directed by {Artist} is available.");
        }
        else
        {
            System.Console.WriteLine($"The CD {Title} directed by {Artist} was borrowed by {Borrower}.");
        }
    }

    public void Return()
    {
        IsBorrowed = false;
        Borrower = "";
    }
}