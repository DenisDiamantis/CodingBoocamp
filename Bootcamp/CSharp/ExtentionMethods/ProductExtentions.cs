using ClassLibrary1;

namespace ExtentionNamespace
{
    //must be static to extend
    public static class ProductExtentions
    {
        public static double GetDiscount(this Product product)
        {
            return product.ProductCost * product.DiscountPercentage / 100;
        }
    }
}
