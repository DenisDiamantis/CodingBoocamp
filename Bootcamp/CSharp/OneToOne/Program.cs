using College;

namespace OneToOneExample
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();

            student.RollNo = 123;
            student.StudentName = "Scott";
            student.Email = "scott@example.com";

            student.Branch = new Branch();
            student.Branch.BranchName = "Computer Science";
            student.Branch.NoOfSemesters = 8;

            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.Branch.BranchName);
            Console.WriteLine(student.Branch.NoOfSemesters);
        }
    }
}