using Arrays;

class Program
{
    static void Main()
    {
        //int[] a = new int[5];

        int[] a = new int[5] { 20, 80, 30, 10, 50 };

        string[] b = new string[5] { "one", "two", "three", "four", "five" };

        //System.Console.WriteLine(a[1]);
        //Array.Clear(a, 2, 3);
        Array.Sort(a);
        for (int i = 0; i < a.Length; i++)
        {
            System.Console.WriteLine(a[i]);

        }
        foreach (string s in b)
        {
            System.Console.WriteLine(s);
        }
        for (int i = b.Length - 1; i >= 0; i--)
        {
            System.Console.WriteLine(b[i]);
        }

        int n = Array.IndexOf(a, 30);
        System.Console.WriteLine(n);


        Employee[] employees = new Employee[] {
        new Employee(){EmpId=1,EmpName="Scott"},
        new Employee(){EmpId=2,EmpName="John"},
        new Employee(){EmpId=3,EmpName="Smith"}
        };

        System.Console.WriteLine(employees[0].EmpName);
        System.Console.WriteLine(employees[1].EmpName);
    }
}
