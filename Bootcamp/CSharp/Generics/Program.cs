class Program
{
    static void Main()
    {
        User<int, int> user1 = new User<int, int>();
        User<bool, int> user2 = new User<bool, int>();
        User<string, int> user3 = new User<string, int>();

        user1.RegistrationStatus = 1234;
        user1.Age = 30;
        user2.RegistrationStatus = true;
        user3.RegistrationStatus = "pending";
        Console.WriteLine(user1.RegistrationStatus + " " + user1.Age);
        Console.WriteLine(user2.RegistrationStatus);
        Console.WriteLine(user3.RegistrationStatus);
    }
}