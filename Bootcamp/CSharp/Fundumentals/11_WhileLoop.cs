class Sample
{
    static void Main()
    {
        //While Loop
        int i = 1;
        while (i <= 10)
        {
            System.Console.WriteLine(i);
            i++;
        }
        System.Console.WriteLine("End of WHILE.");
        System.Console.WriteLine("----------------");

        //Do While Loop
        int j = 1;
        do
        {
            System.Console.WriteLine(j);
            j++;
        } while (j <= 10);
        System.Console.WriteLine("End of DO WHILE.");
        System.Console.WriteLine("----------------");

        //For loop
        for (int k = 1; k < 10; k++)
        {
            if (k == 3)
            {
                System.Console.WriteLine("Number " + k + " Skipped");
                continue;

            }
            if (k == 6)
            {
                System.Console.WriteLine("Threshold of " + k + " reached");
                break;
            }
            System.Console.WriteLine(k);
        }
        System.Console.WriteLine("End of FOR.");
    }
}