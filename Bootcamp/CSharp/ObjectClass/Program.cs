class Program
{
    static void Main()
    {
        /* Person p = new Person();
           p.PersonName = "Michail";
           p.Email = "michail@example.com";

           Person p2 = new Person();
           p2.PersonName = "Michail";
           p2.Email = "michail@example.com";
           Supplier s = new Supplier();
           System.Console.WriteLine(p.Equals(s));
           System.Console.WriteLine(p.Equals(p2));
           p = p2;
           System.Console.WriteLine(p.Equals(p2));
           System.Console.WriteLine(p.ToString());
           System.Console.WriteLine(p); */

        Person p1 = new Person();
        p1.PersonName = "John";
        p1.Email = "john@example.com";

        Person p2 = new Person();
        p2.PersonName = "George";
        p2.Email = "george@example.com";

        Person p3 = new Person();
        p3.PersonName = "John";
        p3.Email = "john@example.com";

        System.Console.WriteLine(p1.ToString());
        System.Console.WriteLine(p2.ToString());
        System.Console.WriteLine(p1.Equals(p2));

        System.Console.WriteLine(p1.ToString());
        System.Console.WriteLine(p3.ToString());
        System.Console.WriteLine(p1.Equals(p3));
    }
}