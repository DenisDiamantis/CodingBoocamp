namespace ClassLibrary1
{
    public class Student
    {
        public double SecureMarks;
        public double MaxMarks;
        public double Percentage;


    }
    public class MarksCalculation
    {
        public void CalculatePercentage(Student student)
        {
            CalculationHelper calculationHelper = new CalculationHelper();
            student.Percentage =
                calculationHelper.Multiply(student.SecureMarks / student.MaxMarks, 100);
        }
        public class CalculationHelper
        {
            public double Multiply(double d1, double d2)
            {
                return d1 * d2;
            }
        }
    }
}