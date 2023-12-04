namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main()
        {
            try
            {
                int a, b;
                Console.Write("Enter first number: ");
                string input1 = Console.ReadLine();
                a = int.Parse(input1);

                Console.Write("Enter second number: ");
                string input2 = Console.ReadLine();
                b = int.Parse(input2);

                int result = a / b;

                Console.WriteLine("Result of division " + result);
            }
            catch (DivideByZeroException dvx)
            {
                Console.WriteLine("Cannot Divide by 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Check your input");
            }
            finally
            {
                Console.WriteLine("Finally always happens");
            }

        }
    }
}