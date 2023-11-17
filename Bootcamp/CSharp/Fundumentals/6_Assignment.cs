class Sample
{
    static void Main()
    {
        int seconds = 288970;
        int minutes = seconds / 60;
        int hours = minutes / 60;
        int days = hours / 24;
        hours %= 24;
        minutes %= 60;
        seconds %= 60;
        System.Console.WriteLine(days + " days, " + hours + " hours, "
            + minutes + " minutes, " + seconds + " seconds");
        System.Console.ReadLine();
    }
}