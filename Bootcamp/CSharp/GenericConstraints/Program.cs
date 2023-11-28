class Program
{
    static void Main()
    {
        MarksPrinter<GraduateStudent> mp = new MarksPrinter<GraduateStudent>();
        mp.stu = new GraduateStudent() { Marks = 80 };
        mp.PrintMarks();
    }
}