public class Person
{
    public string Email { get; set; }
    public string PersonName { get; set; }

    public override bool Equals(object obj)
    {
        Person p = (Person)obj;
        if (this.PersonName == p.PersonName && this.Email == p.Email) return true;
        else return false;
    }
    public override string ToString()
    {
        return $"Person name: {this.PersonName} and email: {this.Email}";
    }
}
/*
public class Supplier
{

}
*/