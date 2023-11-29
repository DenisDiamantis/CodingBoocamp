namespace ListExample
{
    class Program
    {
        static void Main()
        {
            List<int> myList = new List<int>() { 10, 20, 30 };
            myList.Add(40);

            List<int> other = new List<int> { 50, 60, 70 };

            myList.AddRange(other);

            myList.Insert(4, 45);

            List<int> ints = new List<int>() { 200, 300, 400 };

            myList.InsertRange(1, ints);

            myList.Remove(30);

            myList.RemoveAt(0);

            myList.RemoveRange(3, 3);

            List<double> myNumbers = new List<double>() { 12, 234, 15, 6565, 32, 322 };

            myNumbers.Sort();
            myNumbers.Reverse();

            List<string> myFriends = new List<string> { "Scott", "Allen", "John" };

            string[] friends = myFriends.ToArray();


            Console.WriteLine("Using for loop my numbers");
            for (int i = 0; i < myNumbers.Count; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
            Console.WriteLine("\nUsing for loop");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            /*
            Console.WriteLine("\nUsing for each");
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}