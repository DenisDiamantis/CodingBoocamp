namespace ClassLibrary1
{
    public class Sample : IDisposable
    {
        //constructor
        public Sample()
        {
            //file and db connection
            Console.WriteLine("Database is connected");

        }

        public void DisplayDataFromDatabase()
        {
            Console.WriteLine("Reading from Database");
        }

        public void Dispose()
        {
            Console.WriteLine("Database is closed");
        }

        //destructor
        ~Sample()
        {
            //file and db disconnection
            Console.WriteLine("Database is closed");

        }
    }
}
