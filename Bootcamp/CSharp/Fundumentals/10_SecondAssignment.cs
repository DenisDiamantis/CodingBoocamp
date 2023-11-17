class Sample
{
    static void Main()
    {
        //use only if statements
        int num1 = 11;
        int num2 = 5;
        int num3 = 3;
        int biggest;
        if (num1 >= num2)
        {
            if (num1 >= num3)
            {
                biggest = num1;
            }
            else
            {
                biggest = num3;
            }
        }
        else
        {
            if (num2 >= num3)
            {
                biggest = num2;
            }
            else
            {
                biggest = num3;
            }
        }
        System.Console.WriteLine("The biggest number is " + biggest);
        System.Console.ReadLine();
    }
}