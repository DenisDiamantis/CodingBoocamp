class Sample
{
    static void Main()
    {
        //Arithmetic Operators
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b;
        decimal d = a - b;
        decimal e = a * b;
        decimal f = a / b;
        decimal g = a % b;

        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);
        System.Console.ReadKey();

        //Assignment Operators
        a += 20M;          //a = a + 20M;
        a -= 20M;
        a *= 3M;
        a /= 3M;
        a %= 3M;

        //Increment / Decrement Operators
        a = 10M;
        System.Console.WriteLine(++a); //11
        System.Console.WriteLine(a++); //11 a=12M
        System.Console.WriteLine(--a);
        System.Console.WriteLine(a--);

        //Comparison Operators
        bool b1 = a == 10;
        bool b2 = a != 10;
        bool b3 = a <= 10;
        bool b4 = a >= 10;
        bool b5 = a < 10;
        bool b6 = a > 10;

        //Logical Operators
        bool b7 = a == 10 && b == 10;
        bool b8 = a == 10 || b == 10;
        bool b9 = !(a == 10);

        //Concatenation Operator
        string name = "Scott";
        int age = 20;
        string message = "Hey " + name + ", your age is " + age + ".";
        System.Console.WriteLine(message);

        //ternary Operator
        string title = (age < 15) ? "Teenager" : "Adult";
        System.Console.WriteLine(title);

        //Operator precedence
        double z = ((10 + 4) * 30) / 10;
        System.Console.WriteLine(z);
    }
}