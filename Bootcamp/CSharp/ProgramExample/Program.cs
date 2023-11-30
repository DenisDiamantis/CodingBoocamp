using ECommerce;


namespace CollectionOfObjects
{
    class Progam
    {
        static void Main()
        {
            List<Product> products = new List<Product>();
            string choice;
            do
            {
                Console.Write("Enter product ID: ");
                int pid = int.Parse(Console.ReadLine());
                Console.Write("Ente product name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Price: ");
                double unitPrice = double.Parse(Console.ReadLine());
                Console.Write("Enter Date of Manufacture (yyyy-mm-dd): ");
                DateTime dom = DateTime.Parse(Console.ReadLine());

                Product product = new Product()
                {
                    ProductID = pid,
                    ProductName = name,
                    Price = unitPrice,
                    DateOfManufacture = dom
                };

                products.Add(product);

                Console.WriteLine("Product Added");
                Console.WriteLine("Do you want to continue? (Yes/No)");
                choice = Console.ReadLine();

            } while (!(choice.ToUpper() == "NO") && !(choice.ToUpper() == "N"));





            Console.WriteLine("\nProducts: ");
            foreach (Product item in products)
            {
                Console.WriteLine(item.ProductID + " " + item.ProductName
                    + " " + item.Price + " " + item.DateOfManufacture.ToShortDateString());
            }
        }
    }
}