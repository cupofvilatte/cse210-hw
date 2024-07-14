abstract class Book : LibraryItem {
    protected string author;
    protected int pageCount;
    protected string copyrightDate;
    protected string genre;

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int PageCount
    {
        get { return pageCount; }
        set { pageCount = value; }
    }

    public string CopyrightDate
    {
        get { return copyrightDate; }
        set { copyrightDate = value; }
    }

    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }

    public Book(string title, int itemID, string author, int pageCount, string copyrightDate, string genre) : base(title, itemID) {
        this.author = author;
        this.pageCount = pageCount;
        this.copyrightDate = copyrightDate;
        this.genre = genre;
    }

    public override void CheckOut() {

    }

    public override void CheckIn() {

    }
}