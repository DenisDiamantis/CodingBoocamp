using ClassLibrary1;

namespace EventsExample
{
    class Program
    {
        static void Main()
        {
            //create object of subscriber class
            Subscriber subscriber = new Subscriber();

            //create object of subscriber class
            Publisher publisher = new Publisher();

            //create object of second subscriber class
            Subscriber2 subscriber2 = new Subscriber2();

            //hadle the event or subscribe to event
            publisher.MyEvent += subscriber.Add;
            publisher.MyEvent += subscriber2.Multiply;

            //raise event and execute all methods that have subscribed
            publisher.RaiseEvent(10, 20);



        }
    }
}