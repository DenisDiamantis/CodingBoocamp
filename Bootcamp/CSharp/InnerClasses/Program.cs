using ClassLibrary1;
namespace InnerClasses
{
    class Program
    {
        static void Main()
        {
            MarksCalculation.CalculationHelper marksCalculation =
                new MarksCalculation.CalculationHelper();
            Console.WriteLine(marksCalculation.Multiply(10, 5));

            //the right way hiding the Multiply() method
            MarksCalculation mc = new MarksCalculation();
            Student student = new Student() { SecureMarks = 35, MaxMarks = 50 };
            mc.CalculatePercentage(student);
            Console.WriteLine(student.Percentage);
        }
    }
}