namespace LINQExample
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
    }

    class Person
    {
        public string PersonName { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee {EmpId = 101,EmpName="Henry",Job="Designer",City="Boston",Salary=7232},
                new Employee {EmpId = 102,EmpName="Jack",Job="Developer",City="New York",Salary=4500},
                new Employee {EmpId = 103,EmpName="Gabrier",Job="Analyst",City="Tokyo",Salary=1293},
                new Employee {EmpId = 104,EmpName="William",Job="Manager",City="Tokyo",Salary=2873},
                new Employee {EmpId = 105,EmpName="Alexa",Job="Manager",City="New York",Salary=6232}
            };

            //IEnumerable<Employee> result = employees.Where((emp) => emp.City == "Tokyo");

            //var sortedEmployees = employees.OrderByDescending(emp => emp.Job).ThenByDescending((emp) => emp.EmpName);

            List<Employee> filteredEmployees = employees.Where((emp) => emp.Job == "Manager").ToList();
            //Console.WriteLine(filteredEmployees[0].EmpId + ", " + filteredEmployees[0].Job);

            //Employee firstManager = employees.First((emp) => emp.Job == "Manager");

            List<Person> filteredPeople = employees.Select(emp => new Person() { PersonName = emp.EmpName }).ToList();

            Employee firstManager = employees.FirstOrDefault((emp) => emp.Job == "Manager");
            if (firstManager != null)
            {
                Console.WriteLine(firstManager.EmpId + ", " + firstManager.EmpName);
            }
            else
            {
                Console.WriteLine("No manager found!");
            }

            //Console.WriteLine(firstManager.EmpId + ", " + firstManager.EmpName);

            Console.WriteLine("--------------------------------------");
            foreach (Employee emp in filteredEmployees)
            {
                Console.WriteLine(emp.EmpId + ", " + emp.EmpName + ", " + emp.Job + ", " + emp.City + ", " + emp.Salary);
            }
            foreach (Person prsn in filteredPeople)
            {
                Console.WriteLine(prsn.PersonName);
            }
        }
    }
}