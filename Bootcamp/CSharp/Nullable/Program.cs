namespace namespace1
{
    class Person
    {
        public int? NoOfChildren;

    }

    class program
    {
        static void Main()
        {
            Person p1 = new Person() { NoOfChildren = 2 };
            Person p2 = new Person() { NoOfChildren = 5 };
            Person p3 = null;
            Console.WriteLine(p1.NoOfChildren);
            //coalescing operator
            Console.WriteLine(p2.NoOfChildren ?? 0);
            if (p2.NoOfChildren.HasValue)
            {
                int x = p2.NoOfChildren.Value;
                Console.WriteLine(x);
            }
        }
    }
}