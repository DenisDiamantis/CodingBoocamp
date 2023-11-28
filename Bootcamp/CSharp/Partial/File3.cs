namespace Warehouse
{
    public partial class Product
    {
        partial void GetTax()
        {
            double tax = Cost * 10 / 100;
            Console.WriteLine(tax);
        }
    }
}
