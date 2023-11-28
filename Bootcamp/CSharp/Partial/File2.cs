namespace Warehouse
{
    public partial class Product
    {
        private int _cost;

        public int Cost { get => _cost; set => _cost = value; }
        public void CallGetTax()
        {
            GetTax();
        }
    }
}
