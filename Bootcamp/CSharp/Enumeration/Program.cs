class Program
{
    static void Main()
    {
        Person person = new Person();
        person.PersonName = "Michail";
        person.Email = "michail@example.com";
        person.AgeGroup = Person.AgeGroupEnumeration.Adult;
        Console.WriteLine(person.AgeGroup);
    }
}