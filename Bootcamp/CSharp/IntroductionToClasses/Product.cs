public class Product
{
    public int productID;
    public string productName;
    public double price;
    public double tax;
    public int quantityInStock;
    public static int totalNoProducts;
    public const string CategoryName = "Electronics";
    //public readonly string CategoryName = "Electronics";
    public readonly string dateOfPurchase;
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
    public void CalculateTax()
    {
        double t;
        if (price < 20000)
        {
            t = price * 10 / 100;
        }
        else
        {
            t = price * 12.5 / 100;
        }
        tax = t;
    }

}