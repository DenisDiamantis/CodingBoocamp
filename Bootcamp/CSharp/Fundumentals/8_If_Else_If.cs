class Sample
{
    static void Main()
    {
        int marks = 45;
        char gradeLetter;

        if (marks >= 85)
        {
            gradeLetter = 'O';
        }
        else if (marks >= 60 && marks < 85)
        {
            gradeLetter = 'A';
        }
        else if (marks >= 50 && marks < 60)
        {
            gradeLetter = 'B';
        }
        else if (marks >= 35 && marks < 50)
        {
            gradeLetter = 'C';
        }
        else
        {
            gradeLetter = 'F';
        }
        System.Console.WriteLine(gradeLetter);
    }
}