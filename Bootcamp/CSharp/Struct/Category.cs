public struct Category
{
    private int _categoryID;
    private string _categoryName;

    public int CategoryID { get { return _categoryID; } set { if (value > 1 && value <= 10) _categoryID = value; } }

    public string CategoryName
    {
        get { return _categoryName; }
        set { if (value.Length <= 30) _categoryName = value; }
    }
    public int GetCategoryNameLength() { return _categoryName.Length; }
}