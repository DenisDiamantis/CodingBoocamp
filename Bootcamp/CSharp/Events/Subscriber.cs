namespace EventsExample
{
    public class Subscriber
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }

    public class Subscriber2
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
