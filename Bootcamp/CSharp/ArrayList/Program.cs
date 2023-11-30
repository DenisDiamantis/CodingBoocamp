using System.Collections;

namespace ArrayListExample
{
    class Sample
    {
        public int GetNumber()
        {
            return 10;
        }
        public double GetAnotherNumber()
        {
            return 10.7;
        }

        public string GetMessage()
        {
            return "Hello";

        }
        public Employee GetEmployee
        {
            get { return new Employee() { EmployeeName = "Scott" }; }
        }

    }
    class Employee
    {
        public string EmployeeName { get; set; }

    }
    class Programm
    {
        static void Main()
        {

            ArrayList arrayList = new ArrayList() { 100, 'A' };
            Sample s = new Sample();
            arrayList.Add(s.GetNumber());
            arrayList.Add(s.GetAnotherNumber());
            arrayList.Add(s.GetMessage());
            arrayList.Add(s.GetEmployee);


            foreach (var item in arrayList)
            {

                if (item is Employee emp)
                {
                    Console.WriteLine(emp.EmployeeName);
                }
                else
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}