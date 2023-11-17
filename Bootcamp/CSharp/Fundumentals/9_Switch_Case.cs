class Sample
{
    static void Main()
    {
        char gradeLetter = 'A';

        string gradeDescription;

        switch (gradeLetter)
        {
            case 'A':
                gradeDescription = "Outstanding";
                break;
            case 'B':
                gradeDescription = "Excellent";
                break;
            default:
                gradeDescription = "None";
                break;
        }
        System.Console.WriteLine(gradeDescription);
        System.Console.ReadKey();
    }
}