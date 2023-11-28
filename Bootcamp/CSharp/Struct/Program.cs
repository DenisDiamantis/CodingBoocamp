class Program
{
    static void Main()
    {
        //create structure instance
        Category category = new Category(20, "General");
        //category.CategoryID = 20;
        //category.CategoryName = "General";
        WriteLine(category.CategoryID);
        WriteLine(category.CategoryName);
        WriteLine(category.GetCategoryNameLength());

        Marvel marvel = new Marvel("Thanos");
        marvel.PrintCharacterName();
    }
}