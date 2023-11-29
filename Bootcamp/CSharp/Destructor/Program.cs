using ClassLibrary1;

namespace DestructorExample
{
    class Program
    {
        static void Main()
        {
            using (Sample sample = new Sample())
            {
                sample.DisplayDataFromDatabase();
            }
            Console.WriteLine("some other work here...");
        }
    }
}