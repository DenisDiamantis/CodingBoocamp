namespace TypedVariables
{
    class Program
    {
        static void Main()
        {
            //namespace1.namespace2.namespace3.Person p = 
            //new namespace1.namespace2.namespace3.Person() { PersonName = "Nick" };

            //var guesses the type
            var p = new namespace1.namespace2.namespace3.Person() { PersonName = "Nick" };
            var p2 = "Nick".ToUpper();

            //rarely used too risky
            dynamic x = 12;
            x = "Hello";

        }
    }
}

namespace namespace1
{
    namespace namespace2
    {
        namespace namespace3
        {
            public class Person
            {
                public string PersonName { get; set; }
            }
        }
    }
}
