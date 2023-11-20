public class Sample
{
    static void Main()
    {
        const string developerName = "Michail";

        //Customer c1 = new Customer();
        //Customer c2 = new Customer();

        //Create objects
        Product product1 = new Product();
        Product.totalNoProducts++;
        Product product2 = new Product();
        Product.totalNoProducts++;
        Product product3 = new Product();
        Product.totalNoProducts++;

        //initialize fields
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.price = 20000;
        product1.quantityInStock = 1200;
        product1.CalculateTax();

        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.price = 45000;
        product2.quantityInStock = 3400;
        product2.CalculateTax();

        product3.productID = 1003;
        product3.productName = "Speakers";
        product3.price = 36000;
        product3.quantityInStock = 800;
        product3.CalculateTax();


        System.Console.WriteLine("Product1: ");
        System.Console.WriteLine("Product ID: " + product1.productID);
        System.Console.WriteLine("Product Name: " + product1.productName);
        System.Console.WriteLine("Product Price: " + product1.price);
        System.Console.WriteLine("Product Quantity: " + product1.quantityInStock);
        System.Console.WriteLine("Product date of purchase: " + product1.dateOfPurchase);
        System.Console.WriteLine("Tax: " + product1.tax);
        System.Console.WriteLine("");

        System.Console.WriteLine("Product2: ");
        System.Console.WriteLine("Product ID: " + product2.productID);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Product Price: " + product2.price);
        System.Console.WriteLine("Product Quantity: " + product2.quantityInStock);
        System.Console.WriteLine("Product date of purchase: " + product2.dateOfPurchase);
        System.Console.WriteLine("Tax: " + product2.tax);
        System.Console.WriteLine("");

        System.Console.WriteLine("Product3: ");
        System.Console.WriteLine("Product ID: " + product3.productID);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Product Price: " + product3.price);
        System.Console.WriteLine("Product Quantity: " + product3.quantityInStock);
        System.Console.WriteLine("Product date of purchase: " + product3.dateOfPurchase);
        System.Console.WriteLine("Tax: " + product3.tax);
        System.Console.WriteLine("");

        int totalQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;
        System.Console.WriteLine("Total quantity of products: " + totalQuantity);
        System.Console.WriteLine("");

        System.Console.WriteLine("Total number of products: " + Product.totalNoProducts);
        System.Console.WriteLine("");
        System.Console.WriteLine("Category: " + Product.CategoryName);

        System.Console.ReadKey();

    }
}