namespace DictionaryExample
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> employees = new Dictionary<int, string>() {
                {101,"Scott" },
                {103,"Smith" },
                {102,"Allen" }

            };

            //remove
            employees.Remove(102);

            //for each loop dictionary
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Key + ", " + employee.Value);
            }

            //get value based on key
            string s = employees[101];
            Console.WriteLine("\nVallue at 101: " + s);

            Dictionary<int, string>.KeyCollection keys = employees.Keys;
            foreach (int item in keys)
            {
                Console.WriteLine(item);
            }

            //trying to add a duplicate key
            //employees.Add(103, "Scott");

            //contains key
            bool a = employees.ContainsKey(101);
            Console.WriteLine("ContainsKey: " + a);
            bool b = employees.ContainsValue("Scott");
            Console.WriteLine("ContainsValue" + b);

            //clear
            employees.Clear();

        }
    }
}