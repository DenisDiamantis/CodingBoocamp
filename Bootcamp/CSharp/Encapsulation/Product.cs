public class Product
{
    private int productID;
    private string productName;
    private double price;
    private double tax;
    private int quantityInStock;
    private static int totalNoProducts;
    public const string CategoryName = "Electronics";
    //public readonly string CategoryName = "Electronics";
    private readonly string dateOfPurchase;
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
    public string GetDateOfPurchase() { return dateOfPurchase; }
    public void SetProductID(int productID) { this.productID = productID; }
    public int GetProductID() { return this.productID; }
    public void SetProductName(string productName) { this.productName = productName; }
    public string GetProductName() { return this.productName; }
    public double GetPrice() { return this.price; }
    public double GetTax() { return this.tax; }
    public int GetQuantityInStock() { return this.quantityInStock; }
    public void SetPrice(double price) { this.price = price; }
    public void SetQuantityInStock(int quantityInStock) { this.quantityInStock = quantityInStock; }
    public void SetTax(double tax) { this.tax = tax; }

    public static int GetTotalNoProducts() { return totalNoProducts; }
    public static void SetTotalNoProducts(int value) { totalNoProducts = value; }

    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        int total = 0;
        total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        return total;
    }
    public void CalculateTax(/*ref*/ double percentage = 10)
    {
        //percentage = 10.47;
        double t;
        if (price < 20000)
        {
            t = price * 10 / 100;
        }
        else
        {
            t = price * percentage / 100;
        }
        tax = t;
    }
    public void CalculateTax(double price, double percentage)
    {

    }
}