namespace MyDotNetAPIProject;

public class QueryParameters
{
    // Maximum number of records that can be requested per page
    const int _maxSize = 100;

    // Default number of records to return per page
    private int _size = 50;

    // The page number to retrieve (default is page 1)
    public int Page { get; set; } = 1;

    // The size (number of records) to return per page, with a maximum limit
    public int Size 
    {
        get { return _size; }
        set { _size = Math.Min(_maxSize, value); }
    }
}
