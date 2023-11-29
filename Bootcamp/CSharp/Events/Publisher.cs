namespace ClassLibrary1
{
    //delegate type
    public delegate void MyDelegateType(int a, int b);

    public class Publisher
    {
        /* //private delegate
         private MyDelegateType myDelegate;

         //create event
         public event MyDelegateType myEvent
         {
             add { myDelegate += value; }
             remove { myDelegate -= value; }
         }
        */
        public event MyDelegateType MyEvent;
        //raise/call event
        public void RaiseEvent(int a, int b)
        {
            if (this.MyEvent != null)
            {
                this.MyEvent(a, b);
            }
        }
    }
}
