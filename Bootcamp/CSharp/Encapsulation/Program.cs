public class Sample
{
    static void Main()
    {
        const string developerName = "Michail";

        //Customer c1 = new Customer();
        //Customer c2 = new Customer();

        //Create objects
        Product product1 = new Product();
        Product.SetTotalNoProducts(Product.GetTotalNoProducts() + 1);//1
        Product product2 = new Product();
        Product.SetTotalNoProducts(Product.GetTotalNoProducts() + 1);//2
        Product product3 = new Product();
        Product.SetTotalNoProducts(Product.GetTotalNoProducts() + 1);//3

        //initialize fields
        product1.SetProductID(1001);
        product1.SetProductName("Mobile");
        product1.SetPrice(20000);
        product1.SetQuantityInStock(1200);
        product1.CalculateTax(percentage: 9.2);

        product2.SetProductID(1002);
        product2.SetProductName("Laptop");
        product2.SetPrice(45000);
        product2.SetQuantityInStock(3400);
        product2.CalculateTax(7.4);

        product3.SetProductID(1003);
        product3.SetProductName("Speakers");
        product3.SetPrice(36000);
        product3.SetQuantityInStock(800);
        product3.CalculateTax();

        //System.Console.WriteLine("-------------------method parameter--------------------");
        //double p = 7.4;
        //product2.CalculateTax(ref p);
        //System.Console.WriteLine("p is " + p);
        //System.Console.WriteLine("-------------------method parameter--------------------");


        System.Console.WriteLine("Product1: ");
        System.Console.WriteLine("Product ID: " + product1.GetProductID());
        System.Console.WriteLine("Product Name: " + product1.GetProductName());
        System.Console.WriteLine("Product Price: " + product1.GetPrice());
        System.Console.WriteLine("Product Quantity: " + product1.GetQuantityInStock());
        System.Console.WriteLine("Product date of purchase: " + product1.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + product1.GetTax());
        System.Console.WriteLine("");

        System.Console.WriteLine("Product2: ");
        System.Console.WriteLine("Product ID: " + product2.GetProductID());
        System.Console.WriteLine("Product Name: " + product2.GetProductName());
        System.Console.WriteLine("Product Price: " + product2.GetPrice());
        System.Console.WriteLine("Product Quantity: " + product2.GetQuantityInStock());
        System.Console.WriteLine("Product date of purchase: " + product2.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + product2.GetTax());
        System.Console.WriteLine("");


        System.Console.WriteLine("Product3: ");
        System.Console.WriteLine("Product ID: " + product3.GetProductID());
        System.Console.WriteLine("Product Name: " + product3.GetProductName());
        System.Console.WriteLine("Product Price: " + product3.GetPrice());
        System.Console.WriteLine("Product Quantity: " + product3.GetQuantityInStock());
        System.Console.WriteLine("Product date of purchase: " + product3.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + product3.GetTax());
        System.Console.WriteLine("");

        //total quantity
        //int totalQuantity = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();

        int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);

        System.Console.WriteLine("Total quantity of products: " + totalQuantity);
        System.Console.WriteLine("");

        System.Console.WriteLine("Total number of products: " + Product.GetTotalNoProducts());
        System.Console.WriteLine("");
        System.Console.WriteLine("Category: " + Product.CategoryName);

        System.Console.ReadKey();

    }
}