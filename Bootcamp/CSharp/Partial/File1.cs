namespace Warehouse
{
    public partial class Product
    {
        private int _productID;

        public int ProductID { get => _productID; set => _productID = value; }

        partial void GetTax();
    }
}
