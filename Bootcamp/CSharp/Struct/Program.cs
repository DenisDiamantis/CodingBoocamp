using static System.Console;

class Program
{
    static void Main()
    {
        //create structure instance
        Category category = new Category();
        category.CategoryID = 20;
        category.CategoryName = "General";
        WriteLine(category.CategoryID);
        WriteLine(category.CategoryName);
        WriteLine(category.GetCategoryNameLength());
    }
}