using ClassLibrary1;


namespace DelegateExample
{
    class Program
    {
        static void Main()
        {
            //create object of sample class
            Sample sample = new Sample();

            //create reference variable of MyDelegateType
            MyDelegateType myDelegate;

            //add ref of first method
            myDelegate = sample.Add;

            //add ref of second method
            myDelegate += sample.Multiply;

            //add single method to delegate with return type
            //myDelegate = new MyDelegateType(sample.Add);

            //invoke method using delegate object
            //Console.WriteLine(myDelegate.Invoke(30, 40));
            myDelegate.Invoke(30, 40);

        }
    }
}