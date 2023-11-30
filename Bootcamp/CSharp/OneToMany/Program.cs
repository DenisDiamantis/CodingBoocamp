using College;

namespace OneToMany
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();
            student.RollNo = 123;
            student.StudentName = "Scott";
            student.Email = "scott@example.com";
            student.Examinations = new List<Examination>();

            student.Examinations.Add(new Examination
            {
                ExaminationName = "Module Test 1",
                Month = 5,
                Year = 2021,
                MaxMarks = 100,
                SecureMarks = 70
            });
            student.Examinations.Add(new Examination
            {
                ExaminationName = "Module Test 2",
                Month = 7,
                Year = 2022,
                MaxMarks = 100,
                SecureMarks = 80
            });
            student.Examinations.Add(new Examination
            {
                ExaminationName = "Module Test 3",
                Month = 9,
                Year = 2023,
                MaxMarks = 100,
                SecureMarks = 90
            });

            Console.WriteLine("Roll No: " + student.RollNo);
            Console.WriteLine("Student name: " + student.StudentName);
            Console.WriteLine("Email: " + student.Email);
            Console.WriteLine("Examinations: ");

            foreach (Examination item in student.Examinations)
            {
                Console.WriteLine($"{item.ExaminationName}, {item.Year}, {item.Month}, {item.SecureMarks}/{item.MaxMarks}");
            }

        }
    }
}