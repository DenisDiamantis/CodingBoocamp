using ClassLibrary1;
using ExtentionNamespace;

namespace ExtentionMethods
{
    class Program
    {
        static void Main()
        {
            Product product = new Product() { ProductCost = 1000, DiscountPercentage = 10 };

            Console.WriteLine(product.GetDiscount());
        }
    }
}