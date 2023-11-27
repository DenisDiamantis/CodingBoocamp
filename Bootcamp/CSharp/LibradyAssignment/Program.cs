class Library
{
    static void Main()
    {
        Book book1 = new Book("John Smith", "Hello World", "1234B");

        book1.Borrow("Barney Stinson");
        book1.Print();
        Book book2 = new Book("Michael Scott", "The Office", "1274B");
        book2.Print();
        DVD dvd1 = new DVD("Narnia", "Michael Bay", 120);
        dvd1.Borrow("Ted Stinson");
        dvd1.Print();
        CD cd1 = new CD("Shape of you", "Ed Sheeran", 8);
        cd1.Print();

    }
}